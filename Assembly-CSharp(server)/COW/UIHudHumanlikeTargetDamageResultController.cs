using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001685 RID: 5765
	[Token(Token = "0x2001685")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F04EC", Offset = "0x10F04EC")]
	public class UIHudHumanlikeTargetDamageResultController : UIBaseController
	{
		// Token: 0x060068BC RID: 26812 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0x197D7D4", Offset = "0x197D7D4", VA = "0x7BBC17D7D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0x197D824", Offset = "0x197D824", VA = "0x7BBC17D824", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0x197DBBC", Offset = "0x197DBBC", VA = "0x7BBC17DBBC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BF")]
		[Address(RVA = "0x197DC88", Offset = "0x197DC88", VA = "0x7BBC17DC88")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C0")]
		[Address(RVA = "0x197DC98", Offset = "0x197DC98", VA = "0x7BBC17DC98")]
		private void OnHumanTargetHumanBecameInVisible(params object[] data)
		{
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C1")]
		[Address(RVA = "0x197DCA8", Offset = "0x197DCA8", VA = "0x7BBC17DCA8")]
		private void OnBtnSwitchClick()
		{
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C2")]
		[Address(RVA = "0x197DD44", Offset = "0x197DD44", VA = "0x7BBC17DD44")]
		private void OnCleanDataBtnClick()
		{
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C3")]
		[Address(RVA = "0x197DEC8", Offset = "0x197DEC8", VA = "0x7BBC17DEC8")]
		public void UpdateData(TNugLVg t, uint realDamage, uint shieldDamage)
		{
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C4")]
		[Address(RVA = "0x197E000", Offset = "0x197E000", VA = "0x7BBC17E000")]
		private void UpdateVal(float dura)
		{
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C5")]
		[Address(RVA = "0x197DD48", Offset = "0x197DD48", VA = "0x7BBC17DD48")]
		private void ClearAllData()
		{
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C6")]
		[Address(RVA = "0x197E214", Offset = "0x197E214", VA = "0x7BBC17E214")]
		public UIHudHumanlikeTargetDamageResultController()
		{
		}

		// Token: 0x04008563 RID: 34147
		[Token(Token = "0x4008563")]
		[FieldOffset(Offset = "0x58")]
		private UIHudHumanlikeTargetDamageResultView m_View;

		// Token: 0x04008564 RID: 34148
		[Token(Token = "0x4008564")]
		[FieldOffset(Offset = "0x60")]
		private float m_BeginDamageTime;

		// Token: 0x04008565 RID: 34149
		[Token(Token = "0x4008565")]
		[FieldOffset(Offset = "0x64")]
		private float m_LastDamageTime;

		// Token: 0x04008566 RID: 34150
		[Token(Token = "0x4008566")]
		[FieldOffset(Offset = "0x68")]
		private float m_DamageResetTime;

		// Token: 0x04008567 RID: 34151
		[Token(Token = "0x4008567")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsFirstHit;

		// Token: 0x04008568 RID: 34152
		[Token(Token = "0x4008568")]
		[FieldOffset(Offset = "0x70")]
		private uint m_TotalEffectDamage;

		// Token: 0x04008569 RID: 34153
		[Token(Token = "0x4008569")]
		[FieldOffset(Offset = "0x74")]
		private uint m_TotalDamage;

		// Token: 0x0400856A RID: 34154
		[Token(Token = "0x400856A")]
		[FieldOffset(Offset = "0x78")]
		private uint m_DPSVal;

		// Token: 0x0400856B RID: 34155
		[Token(Token = "0x400856B")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_RealDamageVal;

		// Token: 0x0400856C RID: 34156
		[Token(Token = "0x400856C")]
		[FieldOffset(Offset = "0x80")]
		private uint m_ShieldVal;

		// Token: 0x0400856D RID: 34157
		[Token(Token = "0x400856D")]
		[FieldOffset(Offset = "0x84")]
		private uint m_HeadShotVal;

		// Token: 0x0400856E RID: 34158
		[Token(Token = "0x400856E")]
		[FieldOffset(Offset = "0x88")]
		private uint m_BodyShotVal;

		// Token: 0x0400856F RID: 34159
		[Token(Token = "0x400856F")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_LimbShotVal;

		// Token: 0x04008570 RID: 34160
		[Token(Token = "0x4008570")]
		[FieldOffset(Offset = "0x90")]
		private bool m_IsShowConfig;
	}
}
