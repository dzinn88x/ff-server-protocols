using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200232F RID: 9007
	[Token(Token = "0x200232F")]
	public class UIHudPlayerStatsView : UIBaseView
	{
		// Token: 0x0600C16E RID: 49518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16E")]
		[Address(RVA = "0x1D84B0C", Offset = "0x1D84B0C", VA = "0x7BBC584B0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C16F RID: 49519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16F")]
		[Address(RVA = "0x1D85060", Offset = "0x1D85060", VA = "0x7BBC585060")]
		public UIHudPlayerStatsView()
		{
		}

		// Token: 0x0400DA65 RID: 55909
		[Token(Token = "0x400DA65")]
		[FieldOffset(Offset = "0x20")]
		public Transform ArmorStats;

		// Token: 0x0400DA66 RID: 55910
		[Token(Token = "0x400DA66")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Mark;

		// Token: 0x0400DA67 RID: 55911
		[Token(Token = "0x400DA67")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Skills;

		// Token: 0x0400DA68 RID: 55912
		[Token(Token = "0x400DA68")]
		[FieldOffset(Offset = "0x38")]
		public Transform OBActiveSkill;

		// Token: 0x0400DA69 RID: 55913
		[Token(Token = "0x400DA69")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelHP;

		// Token: 0x0400DA6A RID: 55914
		[Token(Token = "0x400DA6A")]
		[FieldOffset(Offset = "0x48")]
		public UISprite HPBar;

		// Token: 0x0400DA6B RID: 55915
		[Token(Token = "0x400DA6B")]
		[FieldOffset(Offset = "0x50")]
		public UISprite MedKitBar;

		// Token: 0x0400DA6C RID: 55916
		[Token(Token = "0x400DA6C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject EPNode;

		// Token: 0x0400DA6D RID: 55917
		[Token(Token = "0x400DA6D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelEP;

		// Token: 0x0400DA6E RID: 55918
		[Token(Token = "0x400DA6E")]
		[FieldOffset(Offset = "0x68")]
		public UISprite EPBar;

		// Token: 0x0400DA6F RID: 55919
		[Token(Token = "0x400DA6F")]
		[FieldOffset(Offset = "0x70")]
		public UISprite MushRoomEPBar;

		// Token: 0x0400DA70 RID: 55920
		[Token(Token = "0x400DA70")]
		[FieldOffset(Offset = "0x78")]
		public Transform HypeNode;

		// Token: 0x0400DA71 RID: 55921
		[Token(Token = "0x400DA71")]
		[FieldOffset(Offset = "0x80")]
		public Animator HUDEffectAnimator;

		// Token: 0x0400DA72 RID: 55922
		[Token(Token = "0x400DA72")]
		[FieldOffset(Offset = "0x88")]
		public GameObject DamageEffect;

		// Token: 0x0400DA73 RID: 55923
		[Token(Token = "0x400DA73")]
		[FieldOffset(Offset = "0x90")]
		public GameObject HealthEffect;

		// Token: 0x0400DA74 RID: 55924
		[Token(Token = "0x400DA74")]
		[FieldOffset(Offset = "0x98")]
		public GameObject APNode;

		// Token: 0x0400DA75 RID: 55925
		[Token(Token = "0x400DA75")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LabelAP;

		// Token: 0x0400DA76 RID: 55926
		[Token(Token = "0x400DA76")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite APBar;

		// Token: 0x0400DA77 RID: 55927
		[Token(Token = "0x400DA77")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite iconAP;

		// Token: 0x0400DA78 RID: 55928
		[Token(Token = "0x400DA78")]
		[FieldOffset(Offset = "0xB8")]
		public UIGrid SkillBufferGrid;

		// Token: 0x0400DA79 RID: 55929
		[Token(Token = "0x400DA79")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject CuringMarkedObj;
	}
}
