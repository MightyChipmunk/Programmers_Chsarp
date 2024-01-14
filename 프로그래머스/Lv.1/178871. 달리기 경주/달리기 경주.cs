using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        List<string> answer = new List<string>();
        Dictionary<string, int> order = new Dictionary<string, int>();
        
        for (int i = 0; i < players.Length; i++) {
            order.Add(players[i], i + 1);
        }
        
        for (int i = 0; i < callings.Length; i++) {
            int k = order[callings[i]];
            string key = players[k - 2];
            order[callings[i]]--;
            order[key]++;
            
            players[k - 2] = players[k - 1];
            players[k - 1] = key;
        }
        
        return players;
    }
}