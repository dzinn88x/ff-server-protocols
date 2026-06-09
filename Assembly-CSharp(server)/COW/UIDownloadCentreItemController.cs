using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014E5 RID: 5349
	[Token(Token = "0x20014E5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDB8C", Offset = "0x10EDB8C")]
	public class UIDownloadCentreItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06005B74 RID: 23412 RVA: 0x0001AB50 File Offset: 0x00018D50
		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x22073D4", Offset = "0x22073D4", VA = "0x7BBCA073D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x2207424", Offset = "0x2207424", VA = "0x7BBCA07424", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x220770C", Offset = "0x220770C", VA = "0x7BBCA0770C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x220774C", Offset = "0x220774C", VA = "0x7BBCA0774C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B78")]
		[Address(RVA = "0x2208E68", Offset = "0x2208E68", VA = "0x7BBCA08E68")]
		private void RefreshRewardBtnState()
		{
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B79")]
		[Address(RVA = "0x220905C", Offset = "0x220905C", VA = "0x7BBCA0905C")]
		private void Update()
		{
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0x220AAA0", Offset = "0x220AAA0", VA = "0x7BBCA0AAA0")]
		private void OnStartDownloadClick()
		{
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0x220AB68", Offset = "0x220AB68", VA = "0x7BBCA0AB68")]
		private void OnPauseDownloadClick()
		{
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0x220AE20", Offset = "0x220AE20", VA = "0x7BBCA0AE20")]
		private void OnDeleteDownloadClick()
		{
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0x220B4F0", Offset = "0x220B4F0", VA = "0x7BBCA0B4F0")]
		private void OnRetryDownloadClick()
		{
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0x220B654", Offset = "0x220B654", VA = "0x7BBCA0B654")]
		private void OnRewardBtnClick()
		{
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0x220B6B0", Offset = "0x220B6B0", VA = "0x7BBCA0B6B0", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x0001AB68 File Offset: 0x00018D68
		[Token(Token = "0x6005B80")]
		[Address(RVA = "0x220B7BC", Offset = "0x220B7BC", VA = "0x7BBCA0B7BC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B81")]
		[Address(RVA = "0x220B800", Offset = "0x220B800", VA = "0x7BBCA0B800")]
		public UIDownloadCentreItemController()
		{
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x220B8A8", Offset = "0x220B8A8", VA = "0x7BBCA0B8A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F618", Offset = "0x113F618")]
		private void <OnPauseDownloadClick>b__16_0()
		{
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x220B8F0", Offset = "0x220B8F0", VA = "0x7BBCA0B8F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F628", Offset = "0x113F628")]
		private void <OnDeleteDownloadClick>b__17_0()
		{
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x220B934", Offset = "0x220B934", VA = "0x7BBCA0B934")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F638", Offset = "0x113F638")]
		private void <OnDeleteDownloadClick>b__17_1()
		{
		}

		// Token: 0x04007E00 RID: 32256
		[Token(Token = "0x4007E00")]
		[FieldOffset(Offset = "0x70")]
		private UIDownloadCentreItemView m_View;

		// Token: 0x04007E01 RID: 32257
		[Token(Token = "0x4007E01")]
		[FieldOffset(Offset = "0x78")]
		private DownloadInfo m_DownloadInfo;

		// Token: 0x04007E02 RID: 32258
		[Token(Token = "0x4007E02")]
		[FieldOffset(Offset = "0x80")]
		private UIModelOptionalDownload m_Model;

		// Token: 0x04007E03 RID: 32259
		[Token(Token = "0x4007E03")]
		[FieldOffset(Offset = "0x88")]
		private ResLoaderInfo m_FileLoader;

		// Token: 0x04007E04 RID: 32260
		[Token(Token = "0x4007E04")]
		[FieldOffset(Offset = "0x90")]
		private EDownloadContextState m_LastShowedState;

		// Token: 0x04007E05 RID: 32261
		[Token(Token = "0x4007E05")]
		[FieldOffset(Offset = "0x94")]
		private bool m_IsInSpeedUp;

		// Token: 0x04007E06 RID: 32262
		[Token(Token = "0x4007E06")]
		[FieldOffset(Offset = "0x0")]
		private static Color SINGLE_FILE_BG_COLOR;

		// Token: 0x04007E07 RID: 32263
		[Token(Token = "0x4007E07")]
		[FieldOffset(Offset = "0x10")]
		private static Color ALL_FILE_BG_COLOR;

		// Token: 0x04007E08 RID: 32264
		[Token(Token = "0x4007E08")]
		[FieldOffset(Offset = "0x20")]
		private static Color STATE_FAILED_COLOR;
	}
}
