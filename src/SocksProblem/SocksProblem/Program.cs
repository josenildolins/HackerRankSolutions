// See https://aka.ms/new-console-template for more information

List<int> socks = new List<int>() { 1,2,1,2,1,3,2};
var pairs = sockMerchant(7,socks);
Console.WriteLine("You have " + pairs + " pairs of socks!!!");

static int sockMerchant(int n, List<int> ar)
{
    IDictionary<int,int> frequency = new Dictionary<int,int>();
    int sock = 0;
    int pairs = 0;

    for (int i = 0; i < n; i++)
    {
        sock = ar[i];

        if (!frequency.ContainsKey(sock))
        {
            frequency[sock] = 1;
        }
        else
        {
            frequency[sock]++;
        }
    }

    foreach (var item in frequency.Values)
    {
        pairs += item / 2;

    }

    return pairs;
}
