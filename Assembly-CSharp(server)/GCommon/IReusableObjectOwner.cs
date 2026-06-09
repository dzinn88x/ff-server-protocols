using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FF0 RID: 4080
	[Token(Token = "0x2000FF0")]
	public interface IReusableObjectOwner
	{
		// Token: 0x06003C7D RID: 15485
		[Token(Token = "0x6003C7D")]
		void OnReusableObjectRecycled(ResourceID rID, GameObject obj);
	}
}
