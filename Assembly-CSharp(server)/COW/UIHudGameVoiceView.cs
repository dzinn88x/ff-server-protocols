using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D9 RID: 8921
	[Token(Token = "0x20022D9")]
	public class UIHudGameVoiceView : UIBaseView
	{
		// Token: 0x0600C0C2 RID: 49346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C2")]
		[Address(RVA = "0x1C16974", Offset = "0x1C16974", VA = "0x7BBC416974", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C3")]
		[Address(RVA = "0x1C16DA8", Offset = "0x1C16DA8", VA = "0x7BBC416DA8")]
		public UIHudGameVoiceView()
		{
		}

		// Token: 0x0400D6BF RID: 54975
		[Token(Token = "0x400D6BF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SpeakerMuteToggle;

		// Token: 0x0400D6C0 RID: 54976
		[Token(Token = "0x400D6C0")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpeakerNotMuteSprite;

		// Token: 0x0400D6C1 RID: 54977
		[Token(Token = "0x400D6C1")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SpeakerMutedSprite;

		// Token: 0x0400D6C2 RID: 54978
		[Token(Token = "0x400D6C2")]
		[FieldOffset(Offset = "0x38")]
		public UISprite CloseSprite;

		// Token: 0x0400D6C3 RID: 54979
		[Token(Token = "0x400D6C3")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle MicroPhoneMuteToggle;

		// Token: 0x0400D6C4 RID: 54980
		[Token(Token = "0x400D6C4")]
		[FieldOffset(Offset = "0x48")]
		public UISprite MicSprite;

		// Token: 0x0400D6C5 RID: 54981
		[Token(Token = "0x400D6C5")]
		[FieldOffset(Offset = "0x50")]
		public GameObject TeammateVoiceTemp;

		// Token: 0x0400D6C6 RID: 54982
		[Token(Token = "0x400D6C6")]
		[FieldOffset(Offset = "0x58")]
		public GameObject VoiceMutePanel;

		// Token: 0x0400D6C7 RID: 54983
		[Token(Token = "0x400D6C7")]
		[FieldOffset(Offset = "0x60")]
		public UIButton VoicePanelMaskBtn;

		// Token: 0x0400D6C8 RID: 54984
		[Token(Token = "0x400D6C8")]
		[FieldOffset(Offset = "0x68")]
		public UISprite MutePanelBG;

		// Token: 0x0400D6C9 RID: 54985
		[Token(Token = "0x400D6C9")]
		[FieldOffset(Offset = "0x70")]
		public UIButton MuteAllBtn;

		// Token: 0x0400D6CA RID: 54986
		[Token(Token = "0x400D6CA")]
		[FieldOffset(Offset = "0x78")]
		public UISprite MutedAllSprite;

		// Token: 0x0400D6CB RID: 54987
		[Token(Token = "0x400D6CB")]
		[FieldOffset(Offset = "0x80")]
		public UISprite NotMuteAllSprite;

		// Token: 0x0400D6CC RID: 54988
		[Token(Token = "0x400D6CC")]
		[FieldOffset(Offset = "0x88")]
		public Transform Line;

		// Token: 0x0400D6CD RID: 54989
		[Token(Token = "0x400D6CD")]
		[FieldOffset(Offset = "0x90")]
		public GameObject TeamMateContainer;

		// Token: 0x0400D6CE RID: 54990
		[Token(Token = "0x400D6CE")]
		[FieldOffset(Offset = "0x98")]
		public UISprite MuteMask;
	}
}
