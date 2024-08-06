 int[] arr=new int[5];
for(int i=0;i<5;i++){
    string s=Console.ReadLine();
    arr[i]=int.Parse(s);
}
int ham=2000;
for(int i=0;i<3;i++){
    if(arr[i]<=ham) ham=arr[i];
}
int bev=2000;
for(int i=3;i<5;i++){
    if(arr[i]<=bev) bev=arr[i];
}
Console.Write("{0}",ham+bev-50);