using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200192C RID: 6444
	[Token(Token = "0x200192C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5AEC", Offset = "0x10F5AEC")]
	internal class UIHudPlayerAndVehicleStatsController : UIBaseController
	{
		// Token: 0x06008235 RID: 33333 RVA: 0x00023760 File Offset: 0x00021960
		[Token(Token = "0x6008235")]
		[Address(RVA = "0x1D74FB4", Offset = "0x1D74FB4", VA = "0x7BBC574FB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008236")]
		[Address(RVA = "0x1D75004", Offset = "0x1D75004", VA = "0x7BBC575004", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008237")]
		[Address(RVA = "0x1D75130", Offset = "0x1D75130", VA = "0x7BBC575130", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008238 RID: 33336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008238")]
		[Address(RVA = "0x1D7563C", Offset = "0x1D7563C", VA = "0x7BBC57563C")]
		private void OnLocalVehicleUseSkillItem(object[] data)
		{
		}

		// Token: 0x06008239 RID: 33337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008239")]
		[Address(RVA = "0x1D758EC", Offset = "0x1D758EC", VA = "0x7BBC5758EC")]
		private void OnLocalVehicleGetBuff(object[] data)
		{
		}

		// Token: 0x0600823A RID: 33338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600823A")]
		[Address(RVA = "0x1D75B9C", Offset = "0x1D75B9C", VA = "0x7BBC575B9C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600823B RID: 33339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600823B")]
		[Address(RVA = "0x1D76078", Offset = "0x1D76078", VA = "0x7BBC576078")]
		private void OnPlayerGetOnVehicle(object[] data)
		{
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600823C")]
		[Address(RVA = "0x1D764F8", Offset = "0x1D764F8", VA = "0x7BBC5764F8")]
		public void BindPlayer({QAb\u0082~u pID)
		{
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600823D")]
		[Address(RVA = "0x1D7670C", Offset = "0x1D7670C", VA = "0x7BBC57670C")]
		private void OnPlayerPostInit(params object[] data)
		{
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600823E")]
		[Address(RVA = "0x1D773E8", Offset = "0x1D773E8", VA = "0x7BBC5773E8")]
		private void OnHPChanged(params object[] data)
		{
		}

		// Token: 0x0600823F RID: 33343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600823F")]
		[Address(RVA = "0x1D7755C", Offset = "0x1D7755C", VA = "0x7BBC57755C")]
		private void OnVehicleShieldHPChanged(params object[] data)
		{
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008240")]
		[Address(RVA = "0x1D776CC", Offset = "0x1D776CC", VA = "0x7BBC5776CC")]
		private void OnGetOnVehicle(params object[] data)
		{
		}

		// Token: 0x06008241 RID: 33345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008241")]
		[Address(RVA = "0x1D76884", Offset = "0x1D76884", VA = "0x7BBC576884")]
		private void RefreshHP(bool isDead)
		{
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008242")]
		[Address(RVA = "0x1D76B10", Offset = "0x1D76B10", VA = "0x7BBC576B10")]
		private void RefreshVehicleShieldHP(uint shieldHP)
		{
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008243")]
		[Address(RVA = "0x1D77A10", Offset = "0x1D77A10", VA = "0x7BBC577A10")]
		private void OnAddPlayer(params object[] data)
		{
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008244")]
		[Address(RVA = "0x1D77AF4", Offset = "0x1D77AF4", VA = "0x7BBC577AF4")]
		private void OnObservePlayer(object[] data)
		{
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008245")]
		[Address(RVA = "0x1D77F54", Offset = "0x1D77F54", VA = "0x7BBC577F54")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008246")]
		[Address(RVA = "0x1D780D8", Offset = "0x1D780D8", VA = "0x7BBC5780D8")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008247")]
		[Address(RVA = "0x1D76E98", Offset = "0x1D76E98", VA = "0x7BBC576E98")]
		private void RefreshSkillStatus()
		{
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008248")]
		[Address(RVA = "0x1D782BC", Offset = "0x1D782BC", VA = "0x7BBC5782BC")]
		private void OnVehicleEquipmentChanged(params object[] data)
		{
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008249")]
		[Address(RVA = "0x1D77D88", Offset = "0x1D77D88", VA = "0x7BBC577D88")]
		private void RefreshVehicleEquipmentStats()
		{
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600824A")]
		[Address(RVA = "0x1D77A0C", Offset = "0x1D77A0C", VA = "0x7BBC577A0C")]
		private void RefreshVehicleEquipmentStats(LevelVehicle veh)
		{
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600824B")]
		[Address(RVA = "0x1D783A8", Offset = "0x1D783A8", VA = "0x7BBC5783A8")]
		private void ShowVehicleEqipIcon(UISprite s, bool show)
		{
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600824C")]
		[Address(RVA = "0x1D762A0", Offset = "0x1D762A0", VA = "0x7BBC5762A0")]
		private void UpdateBufferView()
		{
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600824D")]
		[Address(RVA = "0x1D783F8", Offset = "0x1D783F8", VA = "0x7BBC5783F8")]
		public UIHudPlayerAndVehicleStatsController()
		{
		}

		// Token: 0x0400938E RID: 37774
		[Token(Token = "0x400938E")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPlayerAndVehicleStatsView m_View;

		// Token: 0x0400938F RID: 37775
		[Token(Token = "0x400938F")]
		[FieldOffset(Offset = "0x60")]
		private {QAb\u0082~u m_BindPlayer;

		// Token: 0x04009390 RID: 37776
		[Token(Token = "0x4009390")]
		[FieldOffset(Offset = "0x78")]
		private uint m_BindVehicleShieldId;

		// Token: 0x04009391 RID: 37777
		[Token(Token = "0x4009391")]
		[FieldOffset(Offset = "0x80")]
		private Player m_Player;

		// Token: 0x04009392 RID: 37778
		[Token(Token = "0x4009392")]
		[FieldOffset(Offset = "0x88")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04009393 RID: 37779
		[Token(Token = "0x4009393")]
		[FieldOffset(Offset = "0x90")]
		private uint m_UpdateCallID;

		// Token: 0x04009394 RID: 37780
		[Token(Token = "0x4009394")]
		[FieldOffset(Offset = "0x98")]
		private List<UIHudVehicleBufferController> m_BufferCtrls;

		// Token: 0x04009395 RID: 37781
		[Token(Token = "0x4009395")]
		[FieldOffset(Offset = "0xA0")]
		public readonly float ColorPlayerStatsAlpha;

		// Token: 0x04009396 RID: 37782
		[Token(Token = "0x4009396")]
		[FieldOffset(Offset = "0xA4")]
		public readonly Color ColorDisableEquipmentStat;

		// Token: 0x04009397 RID: 37783
		[Token(Token = "0x4009397")]
		[FieldOffset(Offset = "0xB4")]
		public readonly Vector3 VehicleHPBarThumbOffset;
	}
}
