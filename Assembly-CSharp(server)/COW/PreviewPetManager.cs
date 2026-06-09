using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200129F RID: 4767
	[Token(Token = "0x200129F")]
	public class PreviewPetManager
	{
		// Token: 0x06004A8C RID: 19084 RVA: 0x000167A0 File Offset: 0x000149A0
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x174969C", Offset = "0x174969C", VA = "0x7BBBF4969C")]
		public static bool CheckPetResABReady(CSSharedItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x000167B8 File Offset: 0x000149B8
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x174987C", Offset = "0x174987C", VA = "0x7BBBF4987C")]
		public static bool CheckPetActionResABReadyByPetID(uint petID)
		{
			return default(bool);
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x000167D0 File Offset: 0x000149D0
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x1749750", Offset = "0x1749750", VA = "0x7BBBF49750")]
		public static bool IsPetResABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x1749A3C", Offset = "0x1749A3C", VA = "0x7BBBF49A3C")]
		public static void GetPetOptionalRes(uint itemID, ref List<ResourceID> collection_res_list)
		{
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A90")]
		[Address(RVA = "0x1749B04", Offset = "0x1749B04", VA = "0x7BBBF49B04")]
		public static void GetPetOptionalRes(CSSharedItemData itemData, ref List<ResourceID> collection_res_list)
		{
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A91")]
		[Address(RVA = "0x1749E54", Offset = "0x1749E54", VA = "0x7BBBF49E54")]
		public PreviewPetManager()
		{
		}

		// Token: 0x040072DF RID: 29407
		[Token(Token = "0x40072DF")]
		[FieldOffset(Offset = "0x0")]
		private static bool IsInSingleAssetBundle;
	}
}
