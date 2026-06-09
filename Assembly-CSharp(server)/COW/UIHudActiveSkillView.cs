using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200225A RID: 8794
	[Token(Token = "0x200225A")]
	public class UIHudActiveSkillView : UIBaseView
	{
		// Token: 0x0600BFC5 RID: 49093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC5")]
		[Address(RVA = "0x1883F88", Offset = "0x1883F88", VA = "0x7BBC083F88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFC6 RID: 49094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC6")]
		[Address(RVA = "0x1884330", Offset = "0x1884330", VA = "0x7BBC084330")]
		public UIHudActiveSkillView()
		{
		}

		// Token: 0x0400D32C RID: 54060
		[Token(Token = "0x400D32C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnActiveSkill;

		// Token: 0x0400D32D RID: 54061
		[Token(Token = "0x400D32D")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BtnSprite;

		// Token: 0x0400D32E RID: 54062
		[Token(Token = "0x400D32E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel CancelLabel;

		// Token: 0x0400D32F RID: 54063
		[Token(Token = "0x400D32F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDMask;

		// Token: 0x0400D330 RID: 54064
		[Token(Token = "0x400D330")]
		[FieldOffset(Offset = "0x40")]
		public UISprite CDProgress;

		// Token: 0x0400D331 RID: 54065
		[Token(Token = "0x400D331")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TakeEffectProgress;

		// Token: 0x0400D332 RID: 54066
		[Token(Token = "0x400D332")]
		[FieldOffset(Offset = "0x50")]
		public Transform SkillTakeEffectGo;

		// Token: 0x0400D333 RID: 54067
		[Token(Token = "0x400D333")]
		[FieldOffset(Offset = "0x58")]
		public ParticleSystem SkillReadyAgainEffect;

		// Token: 0x0400D334 RID: 54068
		[Token(Token = "0x400D334")]
		[FieldOffset(Offset = "0x60")]
		public UISprite DisableProgress;

		// Token: 0x0400D335 RID: 54069
		[Token(Token = "0x400D335")]
		[FieldOffset(Offset = "0x68")]
		public UISprite highLightSprite;

		// Token: 0x0400D336 RID: 54070
		[Token(Token = "0x400D336")]
		[FieldOffset(Offset = "0x70")]
		public GameObject petSkill;

		// Token: 0x0400D337 RID: 54071
		[Token(Token = "0x400D337")]
		[FieldOffset(Offset = "0x78")]
		public GameObject petLv1;

		// Token: 0x0400D338 RID: 54072
		[Token(Token = "0x400D338")]
		[FieldOffset(Offset = "0x80")]
		public GameObject petLv2;

		// Token: 0x0400D339 RID: 54073
		[Token(Token = "0x400D339")]
		[FieldOffset(Offset = "0x88")]
		public GameObject petLv3;
	}
}
