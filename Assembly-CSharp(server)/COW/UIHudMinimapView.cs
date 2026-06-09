using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002316 RID: 8982
	[Token(Token = "0x2002316")]
	public class UIHudMinimapView : UIBaseView
	{
		// Token: 0x0600C13C RID: 49468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C13C")]
		[Address(RVA = "0x17B3CB0", Offset = "0x17B3CB0", VA = "0x7BBBFB3CB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C13D")]
		[Address(RVA = "0x17B4220", Offset = "0x17B4220", VA = "0x7BBBFB4220")]
		public UIHudMinimapView()
		{
		}

		// Token: 0x0400D97E RID: 55678
		[Token(Token = "0x400D97E")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition TweenPosition;

		// Token: 0x0400D97F RID: 55679
		[Token(Token = "0x400D97F")]
		[FieldOffset(Offset = "0x28")]
		public Transform RootContainer;

		// Token: 0x0400D980 RID: 55680
		[Token(Token = "0x400D980")]
		[FieldOffset(Offset = "0x30")]
		public GameObject MapQuad;

		// Token: 0x0400D981 RID: 55681
		[Token(Token = "0x400D981")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ForecastEffect;

		// Token: 0x0400D982 RID: 55682
		[Token(Token = "0x400D982")]
		[FieldOffset(Offset = "0x40")]
		public UISprite FactionIcon;

		// Token: 0x0400D983 RID: 55683
		[Token(Token = "0x400D983")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NoSignal;

		// Token: 0x0400D984 RID: 55684
		[Token(Token = "0x400D984")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NoSignalGo;

		// Token: 0x0400D985 RID: 55685
		[Token(Token = "0x400D985")]
		[FieldOffset(Offset = "0x58")]
		public GameObject MapContent;

		// Token: 0x0400D986 RID: 55686
		[Token(Token = "0x400D986")]
		[FieldOffset(Offset = "0x60")]
		public UIPanel SafeZonePanel;

		// Token: 0x0400D987 RID: 55687
		[Token(Token = "0x400D987")]
		[FieldOffset(Offset = "0x68")]
		public Transform MapRot;

		// Token: 0x0400D988 RID: 55688
		[Token(Token = "0x400D988")]
		[FieldOffset(Offset = "0x70")]
		public Transform MapContainer;

		// Token: 0x0400D989 RID: 55689
		[Token(Token = "0x400D989")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Enemy;

		// Token: 0x0400D98A RID: 55690
		[Token(Token = "0x400D98A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject PlayerArrow;

		// Token: 0x0400D98B RID: 55691
		[Token(Token = "0x400D98B")]
		[FieldOffset(Offset = "0x88")]
		public TweenAlpha UavPlayerArrow;

		// Token: 0x0400D98C RID: 55692
		[Token(Token = "0x400D98C")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Arrow;

		// Token: 0x0400D98D RID: 55693
		[Token(Token = "0x400D98D")]
		[FieldOffset(Offset = "0x98")]
		public GameObject SoundTips;

		// Token: 0x0400D98E RID: 55694
		[Token(Token = "0x400D98E")]
		[FieldOffset(Offset = "0xA0")]
		public Transform SoundTipsContainer;

		// Token: 0x0400D98F RID: 55695
		[Token(Token = "0x400D98F")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject SpectatorCamera;

		// Token: 0x0400D990 RID: 55696
		[Token(Token = "0x400D990")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject csEnemyBornPos;

		// Token: 0x0400D991 RID: 55697
		[Token(Token = "0x400D991")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnZoom;

		// Token: 0x0400D992 RID: 55698
		[Token(Token = "0x400D992")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject Effect_Arrow;

		// Token: 0x0400D993 RID: 55699
		[Token(Token = "0x400D993")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject BottomGo;
	}
}
