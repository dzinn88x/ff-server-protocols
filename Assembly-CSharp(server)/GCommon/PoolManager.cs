using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FF3 RID: 4083
	[Token(Token = "0x2000FF3")]
	public static class PoolManager
	{
		// Token: 0x06003C8D RID: 15501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x247AD64", Offset = "0x247AD64", VA = "0x7BBCC7AD64")]
		public static void InitRes(ResourceID resID, int num, uint maxSize = 0U)
		{
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x247AFF8", Offset = "0x247AFF8", VA = "0x7BBCC7AFF8")]
		public static UnityEngine.Object GetRes(ResourceID resID, [Optional] Transform parentTrans)
		{
			return null;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x00012E88 File Offset: 0x00011088
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x247B218", Offset = "0x247B218", VA = "0x7BBCC7B218")]
		public static bool GetRes(ResourceID resID, Action<bool, UnityEngine.Object> callback, out uint ticket, [Optional] Transform parentTrans)
		{
			return default(bool);
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x247B4F8", Offset = "0x247B4F8", VA = "0x7BBCC7B4F8")]
		public static void CancelResAsync(ResourceID resID)
		{
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x247B5B8", Offset = "0x247B5B8", VA = "0x7BBCC7B5B8")]
		public static bool RecyleRes(ResourceID resID, UnityEngine.Object obj, bool worldPositionStays = true)
		{
			return default(bool);
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x247B69C", Offset = "0x247B69C", VA = "0x7BBCC7B69C")]
		public static bool CleanPool(ResourceID resID)
		{
			return default(bool);
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x247B768", Offset = "0x247B768", VA = "0x7BBCC7B768")]
		public static void ClearAll()
		{
		}

		// Token: 0x04004DBF RID: 19903
		[Token(Token = "0x4004DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<ResourceID, SpawnPool> m_ResPool;

		// Token: 0x04004DC0 RID: 19904
		[Token(Token = "0x4004DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject m_Parent;
	}
}
