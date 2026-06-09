using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FFD RID: 4093
	[Token(Token = "0x2000FFD")]
	public interface IResourceRefCacheWithOwner
	{
		// Token: 0x06003D19 RID: 15641
		[Token(Token = "0x6003D19")]
		void Clear();

		// Token: 0x06003D1A RID: 15642
		[Token(Token = "0x6003D1A")]
		UnityEngine.Object TryGet(ResourceID resId);

		// Token: 0x06003D1B RID: 15643
		[Token(Token = "0x6003D1B")]
		UnityEngine.Object GetAndRegister(object owner, ResourceID resId);

		// Token: 0x06003D1C RID: 15644
		[Token(Token = "0x6003D1C")]
		void Register(object owner, UnityEngine.Object res);

		// Token: 0x06003D1D RID: 15645
		[Token(Token = "0x6003D1D")]
		void UnRegister(object owner, UnityEngine.Object res);

		// Token: 0x06003D1E RID: 15646
		[Token(Token = "0x6003D1E")]
		void UnRegisterAll(object owner);

		// Token: 0x06003D1F RID: 15647
		[Token(Token = "0x6003D1F")]
		bool HasUnRefedRes();

		// Token: 0x06003D20 RID: 15648
		[Token(Token = "0x6003D20")]
		bool UnloadOneUnRefedRes();

		// Token: 0x06003D21 RID: 15649
		[Token(Token = "0x6003D21")]
		int UnloadAllUnRefedRes();

		// Token: 0x06003D22 RID: 15650
		[Token(Token = "0x6003D22")]
		bool IsAsyncLoading();

		// Token: 0x06003D23 RID: 15651
		[Token(Token = "0x6003D23")]
		bool IsAsyncLoading(object owner, ResourceID resId);

		// Token: 0x06003D24 RID: 15652
		[Token(Token = "0x6003D24")]
		uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback);

		// Token: 0x06003D25 RID: 15653
		[Token(Token = "0x6003D25")]
		void CancelAsync(object owner, uint ticket);

		// Token: 0x06003D26 RID: 15654
		[Token(Token = "0x6003D26")]
		void CancelAsyncs(object owner);

		// Token: 0x06003D27 RID: 15655
		[Token(Token = "0x6003D27")]
		void CancelAllAsyncs();

		// Token: 0x06003D28 RID: 15656
		[Token(Token = "0x6003D28")]
		void RemoveOwner(object owner);
	}
}
