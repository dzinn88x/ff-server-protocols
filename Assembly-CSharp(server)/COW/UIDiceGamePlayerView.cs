using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021A6 RID: 8614
	[Token(Token = "0x20021A6")]
	public class UIDiceGamePlayerView : UIBaseView
	{
		// Token: 0x0600BE5C RID: 48732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5C")]
		[Address(RVA = "0x2204550", Offset = "0x2204550", VA = "0x7BBCA04550", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE5D RID: 48733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5D")]
		[Address(RVA = "0x22049A4", Offset = "0x22049A4", VA = "0x7BBCA049A4")]
		public UIDiceGamePlayerView()
		{
		}

		// Token: 0x0400C953 RID: 51539
		[Token(Token = "0x400C953")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition MoveTween;

		// Token: 0x0400C954 RID: 51540
		[Token(Token = "0x400C954")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BuffEffect;

		// Token: 0x0400C955 RID: 51541
		[Token(Token = "0x400C955")]
		[FieldOffset(Offset = "0x30")]
		public GameObject AnimationRoot;

		// Token: 0x0400C956 RID: 51542
		[Token(Token = "0x400C956")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GainItem;

		// Token: 0x0400C957 RID: 51543
		[Token(Token = "0x400C957")]
		[FieldOffset(Offset = "0x40")]
		public UISprite GainItemSpr;

		// Token: 0x0400C958 RID: 51544
		[Token(Token = "0x400C958")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PlayerGainItemTxt;

		// Token: 0x0400C959 RID: 51545
		[Token(Token = "0x400C959")]
		[FieldOffset(Offset = "0x50")]
		public GameObject TxtInfo;

		// Token: 0x0400C95A RID: 51546
		[Token(Token = "0x400C95A")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PlayerGainTxtInfo;

		// Token: 0x0400C95B RID: 51547
		[Token(Token = "0x400C95B")]
		[FieldOffset(Offset = "0x60")]
		public TweenPositionArc RwdEffectTween;

		// Token: 0x0400C95C RID: 51548
		[Token(Token = "0x400C95C")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ChangePhaseEffect;

		// Token: 0x0400C95D RID: 51549
		[Token(Token = "0x400C95D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject SpineSkeletonAnimRoot;

		// Token: 0x0400C95E RID: 51550
		[Token(Token = "0x400C95E")]
		[FieldOffset(Offset = "0x78")]
		public GameObject MoveVfxObj;

		// Token: 0x0400C95F RID: 51551
		[Token(Token = "0x400C95F")]
		[FieldOffset(Offset = "0x80")]
		public ParticleSystem MoveVfx;

		// Token: 0x0400C960 RID: 51552
		[Token(Token = "0x400C960")]
		[FieldOffset(Offset = "0x88")]
		public Animation MoveAnim;

		// Token: 0x0400C961 RID: 51553
		[Token(Token = "0x400C961")]
		[FieldOffset(Offset = "0x90")]
		public GameObject TrailVfxObj;

		// Token: 0x0400C962 RID: 51554
		[Token(Token = "0x400C962")]
		[FieldOffset(Offset = "0x98")]
		public ParticleSystem TrailVfx;

		// Token: 0x0400C963 RID: 51555
		[Token(Token = "0x400C963")]
		[FieldOffset(Offset = "0xA0")]
		public Animation TrailAnim;
	}
}
