using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001275 RID: 4725
	[Token(Token = "0x2001275")]
	public interface IOnTriggerEnterExit
	{
		// Token: 0x06004922 RID: 18722
		[Token(Token = "0x6004922")]
		void OnTriggerEnter(Collider other);

		// Token: 0x06004923 RID: 18723
		[Token(Token = "0x6004923")]
		void OnTriggerExit(Collider other);
	}
}
