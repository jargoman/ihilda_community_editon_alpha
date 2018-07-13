using System;
using RippleLibSharp.Keys;

namespace IhildaWallet
{
	public interface IEncrypt
	{

		//byte[] encrypt ( byte[] message, String password );

		//byte[] decrypt ( byte [] cipher, String password );

		byte[] Encrypt ( RippleSeedAddress seed, byte[] salt );

		byte[] Decrypt ( byte [] cipher, byte[] salt, RippleAddress ra );

		String Name { get; /*set;*/}
	}
}

