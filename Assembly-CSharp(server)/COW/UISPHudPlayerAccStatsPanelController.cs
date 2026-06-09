using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200160E RID: 5646
	[Token(Token = "0x200160E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF914", Offset = "0x10EF914")]
	internal class UISPHudPlayerAccStatsPanelController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006534 RID: 25908 RVA: 0x0001CF50 File Offset: 0x0001B150
		[Token(Token = "0x6006534")]
		[Address(RVA = "0x1EEC968", Offset = "0x1EEC968", VA = "0x7BBC6EC968")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006535")]
		[Address(RVA = "0x1EEC9B8", Offset = "0x1EEC9B8", VA = "0x7BBC6EC9B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006536")]
		[Address(RVA = "0x1EECBE8", Offset = "0x1EECBE8", VA = "0x7BBC6ECBE8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006537")]
		[Address(RVA = "0x1EECD74", Offset = "0x1EECD74", VA = "0x7BBC6ECD74")]
		private void RequestPlayerRank(params object[] data)
		{
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006538")]
		[Address(RVA = "0x1EECF9C", Offset = "0x1EECF9C", VA = "0x7BBC6ECF9C")]
		private void OnObserverSwitch(params object[] data)
		{
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006539")]
		[Address(RVA = "0x1EED16C", Offset = "0x1EED16C", VA = "0x7BBC6ED16C")]
		private void ShowRank(params object[] param)
		{
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653A")]
		[Address(RVA = "0x1EED50C", Offset = "0x1EED50C", VA = "0x7BBC6ED50C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0001CF68 File Offset: 0x0001B168
		[Token(Token = "0x600653B")]
		[Address(RVA = "0x1EED580", Offset = "0x1EED580", VA = "0x7BBC6ED580", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653C")]
		[Address(RVA = "0x1EED5C4", Offset = "0x1EED5C4", VA = "0x7BBC6ED5C4")]
		public UISPHudPlayerAccStatsPanelController()
		{
		}

		// Token: 0x040083A5 RID: 33701
		[Token(Token = "0x40083A5")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudPlayerAccStatsPanelView m_View;

		// Token: 0x040083A6 RID: 33702
		[Token(Token = "0x40083A6")]
		[FieldOffset(Offset = "0x60")]
		private UISPHudPlayerAccStatsItemView m_KillCtrl;

		// Token: 0x040083A7 RID: 33703
		[Token(Token = "0x40083A7")]
		[FieldOffset(Offset = "0x68")]
		private UISPHudPlayerAccStatsItemView m_HeadShotCtrl;

		// Token: 0x040083A8 RID: 33704
		[Token(Token = "0x40083A8")]
		[FieldOffset(Offset = "0x70")]
		private UISPHudPlayerAccStatsItemView m_DamageCtrl;

		// Token: 0x040083A9 RID: 33705
		[Token(Token = "0x40083A9")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsRequesting;

		// Token: 0x040083AA RID: 33706
		[Token(Token = "0x40083AA")]
		[FieldOffset(Offset = "0x80")]
		private {QAb\u0082~u m_RequestPlayerID;

		// Token: 0x040083AB RID: 33707
		[Token(Token = "0x40083AB")]
		[FieldOffset(Offset = "0x98")]
		private {QAb\u0082~u m_CurrentTrackingPlayerID;
	}
}
