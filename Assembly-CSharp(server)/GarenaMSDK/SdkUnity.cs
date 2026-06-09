using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK
{
	// Token: 0x02002C03 RID: 11267
	[Token(Token = "0x2002C03")]
	public class SdkUnity
	{
		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600F944 RID: 63812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001221")]
		public static SdkUnity Instance
		{
			[Token(Token = "0x600F944")]
			[Address(RVA = "0x273E7EC", Offset = "0x273E7EC", VA = "0x7BBCF3E7EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F945 RID: 63813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F945")]
		[Address(RVA = "0x274187C", Offset = "0x274187C", VA = "0x7BBCF4187C")]
		private SdkUnity()
		{
		}

		// Token: 0x0600F946 RID: 63814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F946")]
		[Address(RVA = "0x273EAE4", Offset = "0x273EAE4", VA = "0x7BBCF3EAE4")]
		public void Call(string methodName, params object[] args)
		{
		}

		// Token: 0x0600F947 RID: 63815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F947")]
		public T Call<T>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x0600F948 RID: 63816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F948")]
		[Address(RVA = "0x2741918", Offset = "0x2741918", VA = "0x7BBCF41918")]
		public void SetLog(bool debug, bool error)
		{
		}

		// Token: 0x04011CDC RID: 72924
		[Token(Token = "0x4011CDC")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject javaSdkUnity;

		// Token: 0x04011CDD RID: 72925
		[Token(Token = "0x4011CDD")]
		[FieldOffset(Offset = "0x0")]
		private static SdkUnity sInstance;
	}
}
