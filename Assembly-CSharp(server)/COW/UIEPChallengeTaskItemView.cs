using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C8 RID: 8648
	[Token(Token = "0x20021C8")]
	public class UIEPChallengeTaskItemView : UIBaseView
	{
		// Token: 0x0600BEA1 RID: 48801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA1")]
		[Address(RVA = "0x220DE24", Offset = "0x220DE24", VA = "0x7BBCA0DE24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEA2 RID: 48802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA2")]
		[Address(RVA = "0x220E080", Offset = "0x220E080", VA = "0x7BBCA0E080")]
		public UIEPChallengeTaskItemView()
		{
		}

		// Token: 0x0400CB1A RID: 51994
		[Token(Token = "0x400CB1A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400CB1B RID: 51995
		[Token(Token = "0x400CB1B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x0400CB1C RID: 51996
		[Token(Token = "0x400CB1C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Process;

		// Token: 0x0400CB1D RID: 51997
		[Token(Token = "0x400CB1D")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid AwardList;

		// Token: 0x0400CB1E RID: 51998
		[Token(Token = "0x400CB1E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Operation;

		// Token: 0x0400CB1F RID: 51999
		[Token(Token = "0x400CB1F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BGReceived;

		// Token: 0x0400CB20 RID: 52000
		[Token(Token = "0x400CB20")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BGAwarded;

		// Token: 0x0400CB21 RID: 52001
		[Token(Token = "0x400CB21")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BGFnished;
	}
}
