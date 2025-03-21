public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        var countDictionary = new Dictionary<string, int>();
        var graph = new Dictionary<string, List<string>>();
        var queue = new Queue<string>();
        var result = new List<string>();
        for (int i = 0; i < recipes.Length; i++) {
            string recipe = recipes[i];
            countDictionary[recipe] = ingredients[i].Count(); 

            foreach (string ingredient in ingredients[i]) {
                if (!graph.ContainsKey(ingredient)) {
                    graph[ingredient] = new List<string>();
                }
                graph[ingredient].Add(recipe); 
            }
        }
        foreach (string supply in supplies) {
            queue.Enqueue(supply);
        }
        while (queue.Count() > 0) {
            string ingredient = queue.Dequeue();
            if (countDictionary.ContainsKey(ingredient)) {
                result.Add(ingredient);
            }
            if (graph.ContainsKey(ingredient)) {
                foreach (string recipe in graph[ingredient]) {
                    countDictionary[recipe]--;
                    if (countDictionary[recipe] == 0) {
                        queue.Enqueue(recipe);
                    }
                }
            }
        }

        return result;
    }
}