using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A65 RID: 6757
	[Token(Token = "0x2001A65")]
	internal class UIMaskController : UIBaseController
	{
		// Token: 0x06008E39 RID: 36409 RVA: 0x00025F38 File Offset: 0x00024138
		[Token(Token = "0x6008E39")]
		[Address(RVA = "0x1476544", Offset = "0x1476544", VA = "0x7BBBC76544")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E3A")]
		[Address(RVA = "0x1476594", Offset = "0x1476594", VA = "0x7BBBC76594", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E3B")]
		[Address(RVA = "0x14765F8", Offset = "0x14765F8", VA = "0x7BBBC765F8")]
		public void SetMask(bool enabled)
		{
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E3C")]
		[Address(RVA = "0x1476658", Offset = "0x1476658", VA = "0x7BBBC76658")]
		public void SetMaskColor(Color color)
		{
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E3D")]
		[Address(RVA = "0x14766C8", Offset = "0x14766C8", VA = "0x7BBBC766C8")]
		public void BeginMaskAnim(EMaskAnimType maskAnimType, bool isAnimFinsihDisableMask, float fadeDuration, float lightDuration, float stableDuration = 0f)
		{
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x00025F50 File Offset: 0x00024150
		[Token(Token = "0x6008E3E")]
		[Address(RVA = "0x147691C", Offset = "0x147691C", VA = "0x7BBBC7691C")]
		private bool IsTwiceChangeAnim()
		{
			return default(bool);
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x00025F68 File Offset: 0x00024168
		[Token(Token = "0x6008E3F")]
		[Address(RVA = "0x1476930", Offset = "0x1476930", VA = "0x7BBBC76930")]
		private bool IsCurFadeChange()
		{
			return default(bool);
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x00025F80 File Offset: 0x00024180
		[Token(Token = "0x6008E40")]
		[Address(RVA = "0x1476984", Offset = "0x1476984", VA = "0x7BBBC76984")]
		private bool IsCurLightChange()
		{
			return default(bool);
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E41")]
		[Address(RVA = "0x1476800", Offset = "0x1476800", VA = "0x7BBBC76800")]
		private void InitCurChangeAnimStep()
		{
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E42")]
		[Address(RVA = "0x14769D8", Offset = "0x14769D8", VA = "0x7BBBC769D8")]
		private void Update()
		{
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E43")]
		[Address(RVA = "0x14769DC", Offset = "0x14769DC", VA = "0x7BBBC769DC")]
		private void UpdateAnim()
		{
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E44")]
		[Address(RVA = "0x1476A94", Offset = "0x1476A94", VA = "0x7BBBC76A94")]
		private void UpdateChangeAnim()
		{
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E45")]
		[Address(RVA = "0x1476C14", Offset = "0x1476C14", VA = "0x7BBBC76C14")]
		private void OnChangeAnimEnd()
		{
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E46")]
		[Address(RVA = "0x1476A34", Offset = "0x1476A34", VA = "0x7BBBC76A34")]
		private void UpdateStableAnim()
		{
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E47")]
		[Address(RVA = "0x1476CB4", Offset = "0x1476CB4", VA = "0x7BBBC76CB4")]
		private void OnStableAnimEnd()
		{
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E48")]
		[Address(RVA = "0x1476C40", Offset = "0x1476C40", VA = "0x7BBBC76C40")]
		private void OnAnimFinished()
		{
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E49")]
		[Address(RVA = "0x1476CC0", Offset = "0x1476CC0", VA = "0x7BBBC76CC0")]
		public UIMaskController()
		{
		}

		// Token: 0x040099E6 RID: 39398
		[Token(Token = "0x40099E6")]
		[FieldOffset(Offset = "0x58")]
		private UIMaskView m_View;

		// Token: 0x040099E7 RID: 39399
		[Token(Token = "0x40099E7")]
		[FieldOffset(Offset = "0x60")]
		private float m_CurAnimStepChangeDuration;

		// Token: 0x040099E8 RID: 39400
		[Token(Token = "0x40099E8")]
		[FieldOffset(Offset = "0x64")]
		private float m_FadeDuration;

		// Token: 0x040099E9 RID: 39401
		[Token(Token = "0x40099E9")]
		[FieldOffset(Offset = "0x68")]
		private float m_LightDuration;

		// Token: 0x040099EA RID: 39402
		[Token(Token = "0x40099EA")]
		[FieldOffset(Offset = "0x6C")]
		private float m_AnimStableDuration;

		// Token: 0x040099EB RID: 39403
		[Token(Token = "0x40099EB")]
		[FieldOffset(Offset = "0x70")]
		private EMaskAnimType m_AnimType;

		// Token: 0x040099EC RID: 39404
		[Token(Token = "0x40099EC")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isAnimFinsihDisableMask;

		// Token: 0x040099ED RID: 39405
		[Token(Token = "0x40099ED")]
		[FieldOffset(Offset = "0x78")]
		private float m_AnimChangeTimePass;

		// Token: 0x040099EE RID: 39406
		[Token(Token = "0x40099EE")]
		[FieldOffset(Offset = "0x7C")]
		private float m_AnimStableTimePass;

		// Token: 0x040099EF RID: 39407
		[Token(Token = "0x40099EF")]
		[FieldOffset(Offset = "0x80")]
		private UIMaskController.EAnimStep m_AnimStep;

		// Token: 0x040099F0 RID: 39408
		[Token(Token = "0x40099F0")]
		[FieldOffset(Offset = "0x84")]
		private Color m_LerpBeginAnimColor;

		// Token: 0x040099F1 RID: 39409
		[Token(Token = "0x40099F1")]
		[FieldOffset(Offset = "0x94")]
		private Color m_LerpEndAnimColor;

		// Token: 0x02001A66 RID: 6758
		[Token(Token = "0x2001A66")]
		private enum EAnimStep
		{
			// Token: 0x040099F3 RID: 39411
			[Token(Token = "0x40099F3")]
			AnimStep_Finished,
			// Token: 0x040099F4 RID: 39412
			[Token(Token = "0x40099F4")]
			AnimStep_FirstChange,
			// Token: 0x040099F5 RID: 39413
			[Token(Token = "0x40099F5")]
			AnimStep_Stable,
			// Token: 0x040099F6 RID: 39414
			[Token(Token = "0x40099F6")]
			AnimStep_SecondChange
		}
	}
}
