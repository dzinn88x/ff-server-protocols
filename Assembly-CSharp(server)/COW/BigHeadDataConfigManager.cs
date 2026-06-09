using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B7 RID: 4279
	[Token(Token = "0x20010B7")]
	public class BigHeadDataConfigManager : SingletonModule<BigHeadDataConfigManager>
	{
		// Token: 0x060042BD RID: 17085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x14E38C0", Offset = "0x14E38C0", VA = "0x7BBBCE38C0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BE")]
		[Address(RVA = "0x14E38C4", Offset = "0x14E38C4", VA = "0x7BBBCE38C4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BF")]
		[Address(RVA = "0x14E3924", Offset = "0x14E3924", VA = "0x7BBBCE3924")]
		public BigHeadDataConfig GetData(uint map_id, uint mode_id, bool isWaitingRoom)
		{
			return null;
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x14E3A18", Offset = "0x14E3A18", VA = "0x7BBBCE3A18")]
		private BigHeadDataConfig LoadConfig(uint id)
		{
			return null;
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x14E3B8C", Offset = "0x14E3B8C", VA = "0x7BBBCE3B8C")]
		private BigHeadDataConfig LoadConfig(ResourceID resId)
		{
			return null;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x14E3C4C", Offset = "0x14E3C4C", VA = "0x7BBBCE3C4C")]
		public BigHeadDataConfigManager()
		{
		}

		// Token: 0x040051DD RID: 20957
		[Token(Token = "0x40051DD")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, BigHeadDataConfig> DatasMap;
	}
}
