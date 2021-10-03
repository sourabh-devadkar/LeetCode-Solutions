class Solution {
    public boolean isPalindrome(int x) {
        if(x<0){
            return false;
        }
        ArrayList<Integer> a = new ArrayList<>();
        while(x !=0){
            a.add(x%10);
            x = x/10;
        }
        boolean flag = true;
        int n = a.size();
        for(int i=0; i< n/2; i++){
            int b = a.get(i);
            int c = a.get(n-i-1);
            if(b!=c){
                flag = false;
                break;
            }
        }
        return flag;
    }
}
