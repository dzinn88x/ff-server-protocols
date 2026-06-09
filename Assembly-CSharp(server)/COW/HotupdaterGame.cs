using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012C9 RID: 4809
	[Token(Token = "0x20012C9")]
	internal class HotupdaterGame : COWGameBase
	{
		// Token: 0x06004BAD RID: 19373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x1858EBC", Offset = "0x1858EBC", VA = "0x7BBC058EBC", Slot = "17")]
		public override ResourceID[] GetResourceID()
		{
			return null;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x1858F24", Offset = "0x1858F24", VA = "0x7BBC058F24", Slot = "18")]
		public override Type GetUISceneType()
		{
			return null;
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x00016B18 File Offset: 0x00014D18
		[Token(Token = "0x6004BAF")]
		[Address(RVA = "0x1858F94", Offset = "0x1858F94", VA = "0x7BBC058F94", Slot = "24")]
		public override int GetGameType()
		{
			return 0;
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB0")]
		[Address(RVA = "0x1858F9C", Offset = "0x1858F9C", VA = "0x7BBC058F9C", Slot = "9")]
		protected override void OnSceneLoaded()
		{
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x1859028", Offset = "0x1859028", VA = "0x7BBC059028")]
		public HotupdaterGame()
		{
		}

		// Token: 0x040073A0 RID: 29600
		[Token(Token = "0x40073A0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ResourceID[] SCENE_RESOURCE_LIST;
	}
}
