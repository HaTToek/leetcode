class Solution {
public:
    vector<int> sieveOfEratosthenes(int start, int end){
        vector<int> primes;
        if(end < 2) return primes;
        bool* isPrime = new bool[end + 1];

        for(int i=2;i<=end;i++){
            isPrime[i] = true;
        }

        for(int i=2;i*i <= end;i++){
            if(!isPrime[i]) continue;
            for(int j=i*i;j<=end;j+=i){
                isPrime[j] = false;
            }
        }
        for(int i=max(2, start); i<=end;i++){
            if(!isPrime[i]) continue;
            primes.push_back(i);
        }

        return primes;
    }

    vector<int> closestPrimes(int left, int right) {
        vector<int> primes = sieveOfEratosthenes(left, right);
        if(primes.size() == 0 || primes.size() == 1) {
            vector<int> empty(2, -1);
            return empty;
        }
        vector<int> result(2);
        int n = primes.size();
        int minDiff = INT_MAX;
        int prevMinDiff = INT_MAX;

        for (int i = 0; i < n - 1; i++) {
            int diff = primes[i + 1] - primes[i];
            minDiff = min(minDiff, diff);
            if(prevMinDiff != minDiff){
                result.clear();
                result.push_back(primes[i]);
                result.push_back(primes[i+1]);
            }
            prevMinDiff = minDiff;
        }

        return result;
    }
};