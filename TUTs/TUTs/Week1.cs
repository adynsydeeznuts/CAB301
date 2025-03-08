using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Emit;

class Week1 {
    public static float minDistance(List<float> A) {
        float minDist = MathF.Abs(A[0] - A[1]);
        Console.WriteLine(A.Count);
        for(int i = 1; i < A.Count; i++) {
            for(int j = i + 1; j < A.Count; j++) {
                if(MathF.Abs(A[i] - A[j]) < minDist) minDist = MathF.Abs(A[i] - A[j]);
            }
        }
        return minDist;
    }
}

class SortedList(int max) {
    int max = max;
    int[] sortedList = new int[max];
    void sort() {
        if(sortedList.Length > 1) {
            for(int i=0; i < sortedList.Length; i++) {
                if(sortedList[i+1] < sortedList[i]) {
                    int prev_i = sortedList[i];
                    sortedList[i] = sortedList[i+1];
                    sortedList[i+1] = prev_i;
                }
            }
        }
    }
    int Count() {
        return sortedList.Length;
    }
    bool isFull() {
        return Count() == max;
    }
    bool isEmpty() {
        return Count() == 0;
    }
    string clear() {
        Array.Clear(sortedList);
        return "Array cleared";
    }
    string Insert(int num) {
        if(sortedList.Length < max) {
            sortedList[sortedList.Length] = num;
            sort();
            return "Inserted succefully";
        }
        else {
            return "List is full";
        }
    }
    
    void delete(int numToRemove) { 
        sortedList = sortedList.Where(val => val != numToRemove).ToArray();
    }

    string search(int numToFind) { 
        for(int i=0; i < sortedList.Length; i++) {
            if(sortedList[i] == numToFind) {
                return $"number is at position {i}";
            }
        }
        return "Could not find number.";
    }
}

