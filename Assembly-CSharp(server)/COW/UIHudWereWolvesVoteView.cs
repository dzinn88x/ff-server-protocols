using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B7 RID: 9143
	[Token(Token = "0x20023B7")]
	public class UIHudWereWolvesVoteView : UIBaseView
	{
		// Token: 0x0600C27E RID: 49790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27E")]
		[Address(RVA = "0x1D20698", Offset = "0x1D20698", VA = "0x7BBC520698", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27F")]
		[Address(RVA = "0x1D20D8C", Offset = "0x1D20D8C", VA = "0x7BBC520D8C")]
		public UIHudWereWolvesVoteView()
		{
		}

		// Token: 0x0400DE17 RID: 56855
		[Token(Token = "0x400DE17")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400DE18 RID: 56856
		[Token(Token = "0x400DE18")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList ContentList;

		// Token: 0x0400DE19 RID: 56857
		[Token(Token = "0x400DE19")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnVote;

		// Token: 0x0400DE1A RID: 56858
		[Token(Token = "0x400DE1A")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnSkip;

		// Token: 0x0400DE1B RID: 56859
		[Token(Token = "0x400DE1B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel CountDownLabel;

		// Token: 0x0400DE1C RID: 56860
		[Token(Token = "0x400DE1C")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnMap;

		// Token: 0x0400DE1D RID: 56861
		[Token(Token = "0x400DE1D")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MapHint;

		// Token: 0x0400DE1E RID: 56862
		[Token(Token = "0x400DE1E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TitleLabel;

		// Token: 0x0400DE1F RID: 56863
		[Token(Token = "0x400DE1F")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DescLabel;

		// Token: 0x0400DE20 RID: 56864
		[Token(Token = "0x400DE20")]
		[FieldOffset(Offset = "0x68")]
		public UIProgressBar CountDownProgress;

		// Token: 0x0400DE21 RID: 56865
		[Token(Token = "0x400DE21")]
		[FieldOffset(Offset = "0x70")]
		public GameObject SponsorNode;

		// Token: 0x0400DE22 RID: 56866
		[Token(Token = "0x400DE22")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView ChatScrollView;

		// Token: 0x0400DE23 RID: 56867
		[Token(Token = "0x400DE23")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList ChatEasyList;

		// Token: 0x0400DE24 RID: 56868
		[Token(Token = "0x400DE24")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ChatNode;

		// Token: 0x0400DE25 RID: 56869
		[Token(Token = "0x400DE25")]
		[FieldOffset(Offset = "0x90")]
		public UIInput ChatInput;

		// Token: 0x0400DE26 RID: 56870
		[Token(Token = "0x400DE26")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnSendChat;

		// Token: 0x0400DE27 RID: 56871
		[Token(Token = "0x400DE27")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnMic;

		// Token: 0x0400DE28 RID: 56872
		[Token(Token = "0x400DE28")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject MicOn;

		// Token: 0x0400DE29 RID: 56873
		[Token(Token = "0x400DE29")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject MicOff;

		// Token: 0x0400DE2A RID: 56874
		[Token(Token = "0x400DE2A")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnQuickChat;

		// Token: 0x0400DE2B RID: 56875
		[Token(Token = "0x400DE2B")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton BtnSpeaker;

		// Token: 0x0400DE2C RID: 56876
		[Token(Token = "0x400DE2C")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject SpeakerOn;

		// Token: 0x0400DE2D RID: 56877
		[Token(Token = "0x400DE2D")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject SpeakerOff;

		// Token: 0x0400DE2E RID: 56878
		[Token(Token = "0x400DE2E")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject DisChatNode;

		// Token: 0x0400DE2F RID: 56879
		[Token(Token = "0x400DE2F")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject SkipVoteNode;

		// Token: 0x0400DE30 RID: 56880
		[Token(Token = "0x400DE30")]
		[FieldOffset(Offset = "0xE8")]
		public UIGrid SkipNodeGrid;

		// Token: 0x0400DE31 RID: 56881
		[Token(Token = "0x400DE31")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject QuickChatNode;

		// Token: 0x0400DE32 RID: 56882
		[Token(Token = "0x400DE32")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject SpeakerNode;
	}
}
