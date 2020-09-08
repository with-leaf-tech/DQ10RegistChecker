using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10RegistChecker {
    public class CombinationRegist {

        public (List<Dictionary<string, string>>, List<Dictionary<string, string>>) GetBestRegistEquip(List<RegistSet> setList, List<string> allParts) {
            List<List<Dictionary<string, int>>> allList = new List<List<Dictionary<string, int>>>();
            /*
            List<string> allParts = new List<string>();

            string[][][] partsList = setList.Select(x => x.RegistEntityList.Select(y => y.getRegistData().Item2).ToArray()).ToArray();
            for (int i = 0; i < partsList.Length; i++) {
                for (int j = 0; j < partsList[i].Length; j++) {
                    allParts.AddRange(partsList[i][j]);
                }
            }
            allParts = allParts.Distinct().ToList();
            */
            for (int i = 0; i < setList.Count; i++) {
                allList.Add(GetDistinctList(GetCombination(setList[i].RegistEntityList.Select(x => x.getRegistData()).ToArray()).Item1));
            }

            List<Dictionary<string, int>> sumList = new List<Dictionary<string, int>>();
            List<string[]> partslist = new List<string[]>();
            for(int i = 0; i < setList.Select(x => x.Name).ToArray().Length; i++) {
                partslist.Add(allParts.ToArray());
            }

            GetPattern2(setList.Select(x => x.Name).ToArray(), partslist.ToArray(), allParts.ToArray(), allList, 0, null, ref sumList);
            sumList = GetDistinctList(sumList);
            (List<Dictionary<string, int>> resultList, List<Dictionary<string, int>> betterList, List<int> maxCountList) result = GetBetterList(sumList);


            List<Dictionary<string, int>> best = GetDistinctList(result.resultList);
            List<Dictionary<string, int>> better = GetDistinctList(result.betterList);

            List<Dictionary<string, string>> best2 = GetPartsRegistList(best);
            List<Dictionary<string, string>> better2 = GetPartsRegistList(better);

            return (best2, better2);
        }


        public (List<Dictionary<string, int>>, List<Dictionary<string, int>>, List<int>) GetCombination((string name, string[] parts, int count)[] target) {
            Dictionary<string, int> outTarget = new Dictionary<string, int>();
            for (int i = 0; i < target.Length; i++) {
                outTarget[target[i].name] = target[i].count;
            }

            List<List<Dictionary<string, int>>> resultList = new List<List<Dictionary<string, int>>>();
            List<string> allParts = new List<string>();
            for (int i = 0; i < target.Length; i++) {
                allParts.AddRange(target[i].parts);
            }
            allParts = allParts.Distinct().ToList();

            for (int i = 0; i < target.Length; i++) {
                List<Dictionary<string, int>> allCombination = new List<Dictionary<string, int>>();
                GetPattern(allParts.ToArray(), target[i].count, 0, null, ref allCombination);

                resultList.Add(new List<Dictionary<string, int>>());
                for (int j = 0; j < allCombination.Count; j++) {
                    int count = 0;
                    foreach (string key in allCombination[j].Keys) {
                        if (target[i].parts.Contains(key)) {
                            count += allCombination[j][key];
                        }
                        else if (allCombination[j][key] > 0) {
                            count = -1;
                            break;
                        }
                    }
                    if (count >= outTarget[target[i].name]) {
                        resultList[i].Add(allCombination[j]);
                    }
                }
            }

            List<Dictionary<string, int>> sumList = new List<Dictionary<string, int>>();
            GetPattern2(target.Select(x => x.name).ToArray(), target.Select(x => x.parts).ToArray(), allParts.ToArray(), resultList, 0, null, ref sumList);

            sumList = GetDistinctList(sumList);

            (List<Dictionary<string, int>> resultList2, List<Dictionary<string, int>> betterList, List<int> maxCountList) = GetBetterList(sumList);
            //if(resultList2.Count == 0) {
                resultList2 = GetDistinctList(betterList);
            //}
            return (sumList, resultList2, maxCountList);
        }

        public (List<Dictionary<string, int>>, List<Dictionary<string, int>>, List<int>) GetBetterList(List<Dictionary<string, int>> sumList) {
            Dictionary<string, int> usePartsCount = new Dictionary<string, int>();
            usePartsCount[Const.PARTS_HEAD] = 0;
            usePartsCount[Const.PARTS_UPBODY] = 0;
            usePartsCount[Const.PARTS_LOWBODY] = 0;
            usePartsCount[Const.PARTS_LEG] = 0;

            List<int> maxCountList = new List<int>();

            List<Dictionary<string, int>> resultList2 = new List<Dictionary<string, int>>();
            for (int i = 0; i < sumList.Count; i++) {
                Dictionary<string, int> localPartsCount = new Dictionary<string, int>(usePartsCount);
                foreach (string key in sumList[i].Keys) {
                    string groupKey = key.Split(new char[] { '_' })[1];
                    if (!localPartsCount.ContainsKey(groupKey)) {
                        localPartsCount.Add(groupKey, 0);
                    }
                    localPartsCount[groupKey] += sumList[i][key];
                }
                maxCountList.Add(localPartsCount.Values.Max());
                if (localPartsCount.Values.Max() <= 3) {
                    resultList2.Add(sumList[i]);
                }
            }

            List<Dictionary<string, int>> betterList = new List<Dictionary<string, int>>();
            int betterCount = maxCountList.Min();

            //List<int> betterIndexList = maxCountList.Where((x, i) => x == betterCount).Select((x, i) => i).ToList();
            List<int> betterIndexList = maxCountList.Select((x, i) => new int[] { x, i }).Where(x => x[0] == betterCount).Select(x => x[1]).ToList();
            for (int i = 0; i < betterIndexList.Count; i++) {
                betterList.Add(sumList[betterIndexList[i]]);
            }
            resultList2 = GetDistinctList(resultList2);
            betterList = GetDistinctList(betterList);

            return (resultList2, betterList, maxCountList);
        }

        public List<Dictionary<string, int>> GetDistinctList(List<Dictionary<string, int>> list) {
            List<string> checkList = new List<string>();
            List<string> returnList = new List<string>();
            for (int i = 0; i < list.Count; i++) {
                string lineJson = DicToJson(list[i].Where(x => x.Value != 0));
                string returnJson = DicToJson(list[i]);
                if (!checkList.Contains(lineJson)) {
                    checkList.Add(lineJson);
                    returnList.Add(returnJson);
                }
            }
            return returnList.Select(x => JsonToDic(x)).ToList();
        }

        /*
        public List<Dictionary<string, int>> GetDistinctList(List<Dictionary<string, int>> list) {
            List<Dictionary<string, int>> checkList = new List<Dictionary<string, int>>();
            for (int i = 0; i < list.Count; i++) {
                bool listCheck = false;
                for (int j = 0; j < checkList.Count; j++) {
                    bool check = true;
                    foreach (string key in list[i].Keys) {
                        if (!checkList[j].ContainsKey(key) || list[i][key] != checkList[j][key]) {
                            check = false;
                        }
                    }

                    if (check) {
                        listCheck = true;
                        break;
                    }
                }
                if (!listCheck) {
                    checkList.Add(list[i]);
                }
            }
            return checkList;
        }
        */
        public string DicToJson(object obj) {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
        public Dictionary<string, int> JsonToDic(string obj) {
            return JsonConvert.DeserializeObject<Dictionary<string, int>>(obj);
        }

        public void GetPattern(string[] parts, int count, int index, Dictionary<string, int> combination, ref List<Dictionary<string, int>> allCombination) {
            if (index == parts.Length) {
                allCombination.Add(combination);
                return;
            }
            int prevIndex = index;
            if (combination == null) {
                combination = new Dictionary<string, int>();
            }
            Dictionary<string, int> prevCombination = new Dictionary<string, int>(combination);
            for (int i = 0; i <= count; i++) {
                index = prevIndex;
                combination = new Dictionary<string, int>(prevCombination);
                combination[parts[index]] = i;
                GetPattern(parts, count, ++index, combination, ref allCombination);
            }
        }

        public void GetPattern2(string[] name, string[][] parts, string[] allParts, List<List<Dictionary<string, int>>> list, int index, Dictionary<string, int> combination, ref List<Dictionary<string, int>> allCombination) {
            if (index == name.Length) {
                allCombination.Add(combination);
                return;
            }
            int prevIndex = index;
            if (combination == null) {
                combination = new Dictionary<string, int>();
            }
            Dictionary<string, int> prevCombination = new Dictionary<string, int>(combination);
            for (int i = 0; i < list[index].Count; i++) {
                combination = new Dictionary<string, int>(prevCombination);
                foreach (string key in list[index][i].Keys) {
                    string[] listKey = key.Split(new char[] { '_' });
                    string dicKeyStrng = key;
                    if (listKey.Length == 1) {
                        dicKeyStrng = name[index] + "_" + key;
                    }

                    if (!combination.ContainsKey(dicKeyStrng)) {
                        combination.Add(dicKeyStrng, 0);
                    }
                    if (parts[index].Contains(listKey[listKey.Length - 1])) {
                        if (combination[dicKeyStrng] < list[index][i][key]) {
                            combination[dicKeyStrng] = list[index][i][key];
                        }
                    }
                    else {
                        int a = 0;
                    }
                }
                GetPattern2(name, parts, allParts, list, ++index, combination, ref allCombination);
                index = prevIndex;
            }
        }

        public List<Dictionary<string, string>> GetPartsRegistList(List<Dictionary<string, int>> resultList) {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            for (int i = 0; i < resultList.Count; i++) {
                Dictionary<string, List<string>> newLine = new Dictionary<string, List<string>>();
                Dictionary<string, int> regist = resultList[i];
                foreach (string key in regist.Keys) {
                    string[] parts = key.Split(new char[] { '_' });
                    if (!newLine.ContainsKey(parts[1])) {
                        newLine.Add(parts[1], new List<string>());
                    }
                    for (int j = 0; j < regist[key]; j++) {
                        newLine[parts[1]].Add(parts[0]);
                    }
                }
                List<string[]> aa = newLine.Select(x => new string[] { x.Key, string.Join(",", x.Value.OrderBy(y => y)) }).ToList();
                result.Add(aa.ToDictionary(x => x[0], x => x[1]));
            }
            return result;
        }

    }
}
