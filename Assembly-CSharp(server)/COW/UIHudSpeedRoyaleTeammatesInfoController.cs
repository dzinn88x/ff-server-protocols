using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001963 RID: 6499
	[Token(Token = "0x2001963")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F629C", Offset = "0x10F629C")]
	internal class UIHudSpeedRoyaleTeammatesInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008404 RID: 33796 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[Token(Token = "0x6008404")]
		[Address(RVA = "0x166EA20", Offset = "0x166EA20", VA = "0x7BBBE6EA20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008405 RID: 33797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008405")]
		[Address(RVA = "0x166EA70", Offset = "0x166EA70", VA = "0x7BBBE6EA70", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008406")]
		[Address(RVA = "0x166EC84", Offset = "0x166EC84", VA = "0x7BBBE6EC84", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008407")]
		[Address(RVA = "0x166F098", Offset = "0x166F098", VA = "0x7BBBE6F098", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008408")]
		[Address(RVA = "0x166F4CC", Offset = "0x166F4CC", VA = "0x7BBBE6F4CC")]
		private UIHudSpeedRoyaleTeammateItem AddTeammateItem({QAb\u0082~u playerID)
		{
			return null;
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008409")]
		[Address(RVA = "0x166F9D8", Offset = "0x166F9D8", VA = "0x7BBBE6F9D8", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x00023DC0 File Offset: 0x00021FC0
		[Token(Token = "0x600840A")]
		[Address(RVA = "0x166FE74", Offset = "0x166FE74", VA = "0x7BBBE6FE74", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600840B")]
		[Address(RVA = "0x166FEB8", Offset = "0x166FEB8", VA = "0x7BBBE6FEB8")]
		private UIHudSpeedRoyaleTeammateItem GetTeammateItem({QAb\u0082~u pId)
		{
			return null;
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600840C")]
		[Address(RVA = "0x1670068", Offset = "0x1670068", VA = "0x7BBBE70068")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600840D")]
		[Address(RVA = "0x1670240", Offset = "0x1670240", VA = "0x7BBBE70240")]
		private void OnVehicleHPChanged(params object[] data)
		{
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600840E")]
		[Address(RVA = "0x16703AC", Offset = "0x16703AC", VA = "0x7BBBE703AC")]
		private void OnVehicleDead(params object[] data)
		{
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600840F")]
		[Address(RVA = "0x1670548", Offset = "0x1670548", VA = "0x7BBBE70548")]
		private void OnPlayerGetOnVehicle(object[] data)
		{
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008410")]
		[Address(RVA = "0x16707AC", Offset = "0x16707AC", VA = "0x7BBBE707AC")]
		private void OnPlayerGetOffVehicle(object[] data)
		{
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008411")]
		[Address(RVA = "0x167092C", Offset = "0x167092C", VA = "0x7BBBE7092C")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008412")]
		[Address(RVA = "0x1670A2C", Offset = "0x1670A2C", VA = "0x7BBBE70A2C")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008413")]
		[Address(RVA = "0x1670B2C", Offset = "0x1670B2C", VA = "0x7BBBE70B2C")]
		private void OnTeammateQuit(object[] data)
		{
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008414")]
		[Address(RVA = "0x1670C5C", Offset = "0x1670C5C", VA = "0x7BBBE70C5C")]
		private void OnTeamateVadStateChange(object[] data)
		{
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008415")]
		[Address(RVA = "0x1670DE0", Offset = "0x1670DE0", VA = "0x7BBBE70DE0")]
		private void OnTeamateStateChange(object[] data)
		{
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008416")]
		[Address(RVA = "0x1670F7C", Offset = "0x1670F7C", VA = "0x7BBBE70F7C")]
		private void OnTeamInfoGet(object[] data)
		{
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x00023DD8 File Offset: 0x00021FD8
		[Token(Token = "0x6008417")]
		[Address(RVA = "0x166FAFC", Offset = "0x166FAFC", VA = "0x7BBBE6FAFC")]
		private bool CheckToShow({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008418")]
		[Address(RVA = "0x16712CC", Offset = "0x16712CC", VA = "0x7BBBE712CC")]
		public UIHudSpeedRoyaleTeammatesInfoController()
		{
		}

		// Token: 0x04009494 RID: 38036
		[Token(Token = "0x4009494")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSpeedRoyaleTeammatesInfoView m_View;

		// Token: 0x04009495 RID: 38037
		[Token(Token = "0x4009495")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<uint, UIHudSpeedRoyaleTeammateGroup> m_VehicleGroups;

		// Token: 0x04009496 RID: 38038
		[Token(Token = "0x4009496")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<ulong, UIHudSpeedRoyaleTeammateItem> m_TeammatesWithAccountID;

		// Token: 0x04009497 RID: 38039
		[Token(Token = "0x4009497")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, uint> m_PlayerIDToVehicleID;

		// Token: 0x04009498 RID: 38040
		[Token(Token = "0x4009498")]
		[FieldOffset(Offset = "0x78")]
		private UIModelMatch m_MatchModel;
	}
}
