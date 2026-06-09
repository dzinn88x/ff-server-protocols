using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B83 RID: 7043
	[Token(Token = "0x2001B83")]
	public class UIShootingGameRankingItem : MonoBehaviour
	{
		// Token: 0x060097CD RID: 38861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097CD")]
		[Address(RVA = "0x1637D90", Offset = "0x1637D90", VA = "0x7BBBE37D90")]
		public void SetData(int rank, string nickName, uint score, byte createTime, byte delTime, bool needFormatTime)
		{
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097CE")]
		[Address(RVA = "0x1637ED0", Offset = "0x1637ED0", VA = "0x7BBBE37ED0")]
		private void FormatTime(uint score)
		{
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097CF")]
		[Address(RVA = "0x1637FC8", Offset = "0x1637FC8", VA = "0x7BBBE37FC8")]
		public void SetTimeTxt(byte time)
		{
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D0")]
		[Address(RVA = "0x1638184", Offset = "0x1638184", VA = "0x7BBBE38184")]
		public UIShootingGameRankingItem()
		{
		}

		// Token: 0x04009FC8 RID: 40904
		[Token(Token = "0x4009FC8")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Rank;

		// Token: 0x04009FC9 RID: 40905
		[Token(Token = "0x4009FC9")]
		[FieldOffset(Offset = "0x20")]
		public UILabel PlayerName;

		// Token: 0x04009FCA RID: 40906
		[Token(Token = "0x4009FCA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Score;

		// Token: 0x04009FCB RID: 40907
		[Token(Token = "0x4009FCB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Timelabel;

		// Token: 0x04009FCC RID: 40908
		[Token(Token = "0x4009FCC")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BG;

		// Token: 0x04009FCD RID: 40909
		[Token(Token = "0x4009FCD")]
		[FieldOffset(Offset = "0x40")]
		public byte CreateTime;
	}
}
