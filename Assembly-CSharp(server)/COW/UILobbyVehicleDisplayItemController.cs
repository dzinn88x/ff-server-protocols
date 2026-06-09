using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001522 RID: 5410
	[Token(Token = "0x2001522")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE1FC", Offset = "0x10EE1FC")]
	public class UILobbyVehicleDisplayItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06005CE7 RID: 23783 RVA: 0x0001B030 File Offset: 0x00019230
		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x19DB9CC", Offset = "0x19DB9CC", VA = "0x7BBC1DB9CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE8")]
		[Address(RVA = "0x19DBA1C", Offset = "0x19DBA1C", VA = "0x7BBC1DBA1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0x19DBA80", Offset = "0x19DBA80", VA = "0x7BBC1DBA80", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x19DBA88", Offset = "0x19DBA88", VA = "0x7BBC1DBA88", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0x19DC0C8", Offset = "0x19DC0C8", VA = "0x7BBC1DC0C8", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x0001B048 File Offset: 0x00019248
		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0x19DC0CC", Offset = "0x19DC0CC", VA = "0x7BBC1DC0CC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CED")]
		[Address(RVA = "0x19DBEC0", Offset = "0x19DBEC0", VA = "0x7BBC1DBEC0")]
		private void SetQualityBG(int quality)
		{
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0x19DC0D4", Offset = "0x19DC0D4", VA = "0x7BBC1DC0D4")]
		public UILobbyVehicleDisplayItemController()
		{
		}

		// Token: 0x04007ECC RID: 32460
		[Token(Token = "0x4007ECC")]
		[FieldOffset(Offset = "0x70")]
		private UILobbyVehicleDisplayItemView m_View;

		// Token: 0x04007ECD RID: 32461
		[Token(Token = "0x4007ECD")]
		[FieldOffset(Offset = "0x78")]
		private UIModelVehicleDisplay m_Model;

		// Token: 0x04007ECE RID: 32462
		[Token(Token = "0x4007ECE")]
		[FieldOffset(Offset = "0x80")]
		private UIModelOptionalDownload m_optionalDownloadModel;

		// Token: 0x04007ECF RID: 32463
		[Token(Token = "0x4007ECF")]
		[FieldOffset(Offset = "0x88")]
		private VehicleSkinBaseInfo m_Info;

		// Token: 0x04007ED0 RID: 32464
		[Token(Token = "0x4007ED0")]
		[FieldOffset(Offset = "0x90")]
		private UICommonOptionalDownloaderController m_Downloader;
	}
}
