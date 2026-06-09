using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B7 RID: 8631
	[Token(Token = "0x20021B7")]
	internal class UIElitePassLobbyIconView : UIBaseView
	{
		// Token: 0x0600BE7E RID: 48766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7E")]
		[Address(RVA = "0x1AE8B98", Offset = "0x1AE8B98", VA = "0x7BBC2E8B98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7F")]
		[Address(RVA = "0x1AE8D0C", Offset = "0x1AE8D0C", VA = "0x7BBC2E8D0C")]
		public UIElitePassLobbyIconView()
		{
		}

		// Token: 0x0400CA32 RID: 51762
		[Token(Token = "0x400CA32")]
		[FieldOffset(Offset = "0x20")]
		public GameObject EP;

		// Token: 0x0400CA33 RID: 51763
		[Token(Token = "0x400CA33")]
		[FieldOffset(Offset = "0x28")]
		public GameObject EPNewGO;

		// Token: 0x0400CA34 RID: 51764
		[Token(Token = "0x400CA34")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnEP;

		// Token: 0x0400CA35 RID: 51765
		[Token(Token = "0x400CA35")]
		[FieldOffset(Offset = "0x38")]
		public UISprite LobbyEPIcon;
	}
}
