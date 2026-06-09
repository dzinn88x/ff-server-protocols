using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001526 RID: 5414
	[Token(Token = "0x2001526")]
	public class UIVehicleMainController : UICollectionMainBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005D17 RID: 23831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D17")]
		[Address(RVA = "0x1A08998", Offset = "0x1A08998", VA = "0x7BBC208998", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x0001B0C0 File Offset: 0x000192C0
		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x1A08C18", Offset = "0x1A08C18", VA = "0x7BBC208C18")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D19")]
		[Address(RVA = "0x1A08C68", Offset = "0x1A08C68", VA = "0x7BBC208C68", Slot = "28")]
		protected override void GeneratePopMenuData()
		{
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0x1A0909C", Offset = "0x1A0909C", VA = "0x7BBC20909C")]
		public void UpdateDefaultSourseType()
		{
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1B")]
		[Address(RVA = "0x1A091CC", Offset = "0x1A091CC", VA = "0x7BBC2091CC")]
		private void OnPopMenuItemSelected(object obj)
		{
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1C")]
		[Address(RVA = "0x1A09360", Offset = "0x1A09360", VA = "0x7BBC209360")]
		private void OnNewPopMenuItemSelected(object obj)
		{
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1D")]
		[Address(RVA = "0x1A094F8", Offset = "0x1A094F8", VA = "0x7BBC2094F8", Slot = "29")]
		protected override void OnEquipBtnClick()
		{
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1E")]
		[Address(RVA = "0x1A095D8", Offset = "0x1A095D8", VA = "0x7BBC2095D8")]
		public void OnVehicleItemSelected(params object[] obj)
		{
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1F")]
		[Address(RVA = "0x1A097EC", Offset = "0x1A097EC", VA = "0x7BBC2097EC")]
		private void RefreshEquipBtn()
		{
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D20")]
		[Address(RVA = "0x1A097C0", Offset = "0x1A097C0", VA = "0x7BBC2097C0")]
		private void SetItemView(VehicleSkinBaseInfo data)
		{
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x0001B0D8 File Offset: 0x000192D8
		[Token(Token = "0x6005D21")]
		[Address(RVA = "0x1A098D8", Offset = "0x1A098D8", VA = "0x7BBC2098D8", Slot = "32")]
		protected override bool HaveItems()
		{
			return default(bool);
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D22")]
		[Address(RVA = "0x1A0995C", Offset = "0x1A0995C", VA = "0x7BBC20995C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D23")]
		[Address(RVA = "0x1A09AB4", Offset = "0x1A09AB4", VA = "0x7BBC209AB4", Slot = "33")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[Token(Token = "0x6005D24")]
		[Address(RVA = "0x1A09C18", Offset = "0x1A09C18", VA = "0x7BBC209C18", Slot = "34")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x1A09C7C", Offset = "0x1A09C7C", VA = "0x7BBC209C7C")]
		public UIVehicleMainController()
		{
		}

		// Token: 0x04007EE4 RID: 32484
		[Token(Token = "0x4007EE4")]
		[FieldOffset(Offset = "0xA0")]
		private }qPMTAX m_SelectedVehicleData;

		// Token: 0x04007EE5 RID: 32485
		[Token(Token = "0x4007EE5")]
		[FieldOffset(Offset = "0xA8")]
		private VehicleSkinBaseInfo m_SelectedVehicleSkinData;
	}
}
