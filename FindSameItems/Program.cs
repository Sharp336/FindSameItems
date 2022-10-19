void FS(int[] n)
{
    Array.Sort(n);
    
    var previous = n[0];
    var status = false;
    for(var i = 1; i < n.Length; i++) if (n[i] == previous) status = true; else previous = n[i];
    Console.WriteLine(status);
}
FS(new[]{1,2,3,4});
FS(new[]{1,2,3,1});
FS(new[]{8,7,2,5,6,2,8,3,7,5,2,3});
FS(new[]{-1,-2,-1,0,5,6,2,8,3,7});