using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200198C RID: 6540
	[Token(Token = "0x200198C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6874", Offset = "0x10F6874")]
	internal abstract class UIHudVehicleItemButtonController : UIHudButtonBaseController
	{
		// Token: 0x06008565 RID: 34149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008565")]
		[Address(RVA = "0x15EEB64", Offset = "0x15EEB64", VA = "0x7BBBDEEB64", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008566")]
		[Address(RVA = "0x15EEDAC", Offset = "0x15EEDAC", VA = "0x7BBBDEEDAC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008567")]
		[Address(RVA = "0x15EF0F0", Offset = "0x15EF0F0", VA = "0x7BBBDEF0F0", Slot = "34")]
		protected virtual void OnPlayerGetOnVehicle(params object[] ps)
		{
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008568")]
		[Address(RVA = "0x15EFBD0", Offset = "0x15EFBD0", VA = "0x7BBBDEFBD0")]
		protected void OnLocalVehicleEquipChange(params object[] ps)
		{
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008569")]
		[Address(RVA = "0x15EFE2C", Offset = "0x15EFE2C", VA = "0x7BBBDEFE2C")]
		protected void OnLocalVehicleUseItem(params object[] ps)
		{
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600856A")]
		[Address(RVA = "0x15EEFBC", Offset = "0x15EEFBC", VA = "0x7BBBDEEFBC")]
		protected void CheckAndUpdateVisibility()
		{
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600856B")]
		[Address(RVA = "0x15EFCD0", Offset = "0x15EFCD0", VA = "0x7BBBDEFCD0")]
		protected void CheckAndUpdateVisibility(LevelVehicle veh)
		{
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x000242E8 File Offset: 0x000224E8
		[Token(Token = "0x600856C")]
		[Address(RVA = "0x15EFF50", Offset = "0x15EFF50", VA = "0x7BBBDEFF50", Slot = "35")]
		protected virtual bool ShouldHide()
		{
			return default(bool);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600856D")]
		[Address(RVA = "0x15EFF58", Offset = "0x15EFF58", VA = "0x7BBBDEFF58", Slot = "36")]
		protected virtual void UpdateCd(oq^plmP item)
		{
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600856E RID: 34158 RVA: 0x00024300 File Offset: 0x00022500
		[Token(Token = "0x170009B1")]
		protected bool IsInCd
		{
			[Token(Token = "0x600856E")]
			[Address(RVA = "0x15F01A8", Offset = "0x15F01A8", VA = "0x7BBBDF01A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600856F")]
		[Address(RVA = "0x15EF10C", Offset = "0x15EF10C", VA = "0x7BBBDEF10C")]
		protected UIHudVehicleItemButtonController()
		{
		}

		// Token: 0x040094FF RID: 38143
		[Token(Token = "0x40094FF")]
		[FieldOffset(Offset = "0x60")]
		protected TweenFill m_TweenCd;

		// Token: 0x04009500 RID: 38144
		[Token(Token = "0x4009500")]
		[FieldOffset(Offset = "0x68")]
		protected \u0082\u0082xLqO{ m_TargetSlot;

		// Token: 0x04009501 RID: 38145
		[Token(Token = "0x4009501")]
		[FieldOffset(Offset = "0x6C")]
		protected float m_CdEndTime;
	}
}
