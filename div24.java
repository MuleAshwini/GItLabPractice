class div24
{
	public static void main(String args[])
	{
		int n=24;
		System.out.println("Divisiors of 24 are:");
		for(int i=1;i<=n;i++)
		{
			if(n%i==0)
				System.out.println(i);
		}
	}
}