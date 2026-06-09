using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020014E6 RID: 5350
	[Token(Token = "0x20014E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDBC4", Offset = "0x10EDBC4")]
	internal class UIElitePassDocumentController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06005B86 RID: 23430 RVA: 0x0001AB80 File Offset: 0x00018D80
		[Token(Token = "0x6005B86")]
		[Address(RVA = "0x1AE6ACC", Offset = "0x1AE6ACC", VA = "0x7BBC2E6ACC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B87")]
		[Address(RVA = "0x1AE6B1C", Offset = "0x1AE6B1C", VA = "0x7BBC2E6B1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B88")]
		[Address(RVA = "0x1AE6CC0", Offset = "0x1AE6CC0", VA = "0x7BBC2E6CC0")]
		public void SetData(List<EPArchiveInfo> serverDataList)
		{
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B89")]
		[Address(RVA = "0x1AE7370", Offset = "0x1AE7370", VA = "0x7BBC2E7370", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x1AE73B0", Offset = "0x1AE73B0", VA = "0x7BBC2E73B0", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0x1AE7444", Offset = "0x1AE7444", VA = "0x7BBC2E7444", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0x1AE7474", Offset = "0x1AE7474", VA = "0x7BBC2E7474", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x0001AB98 File Offset: 0x00018D98
		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0x1AE75BC", Offset = "0x1AE75BC", VA = "0x7BBC2E75BC", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0x1AE7600", Offset = "0x1AE7600", VA = "0x7BBC2E7600")]
		public UIElitePassDocumentController()
		{
		}

		// Token: 0x04007E09 RID: 32265
		[Token(Token = "0x4007E09")]
		[FieldOffset(Offset = "0x98")]
		private UIElitePassDocumentView m_View;

		// Token: 0x04007E0A RID: 32266
		[Token(Token = "0x4007E0A")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelElitePass m_ModelEP;

		// Token: 0x020014E7 RID: 5351
		[Token(Token = "0x20014E7")]
		public class EPDocumentItemData
		{
			// Token: 0x06005B8F RID: 23439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B8F")]
			[Address(RVA = "0x1AE7314", Offset = "0x1AE7314", VA = "0x7BBC2E7314")]
			public EPDocumentItemData(uint eventId, uint badgeId, string cdnUrl, bool ownedPass, uint badgeCnt)
			{
			}

			// Token: 0x04007E0B RID: 32267
			[Token(Token = "0x4007E0B")]
			[FieldOffset(Offset = "0x10")]
			public uint eventId;

			// Token: 0x04007E0C RID: 32268
			[Token(Token = "0x4007E0C")]
			[FieldOffset(Offset = "0x14")]
			public uint badgeId;

			// Token: 0x04007E0D RID: 32269
			[Token(Token = "0x4007E0D")]
			[FieldOffset(Offset = "0x18")]
			public string cdnUrl;

			// Token: 0x04007E0E RID: 32270
			[Token(Token = "0x4007E0E")]
			[FieldOffset(Offset = "0x20")]
			public bool ownedPass;

			// Token: 0x04007E0F RID: 32271
			[Token(Token = "0x4007E0F")]
			[FieldOffset(Offset = "0x24")]
			public uint badgeCnt;
		}

		// Token: 0x020014E8 RID: 5352
		[Token(Token = "0x20014E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDBFC", Offset = "0x10EDBFC")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06005B90 RID: 23440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B90")]
			[Address(RVA = "0x1AE730C", Offset = "0x1AE730C", VA = "0x7BBC2E730C")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06005B91 RID: 23441 RVA: 0x0001ABB0 File Offset: 0x00018DB0
			[Token(Token = "0x6005B91")]
			[Address(RVA = "0x1AE7608", Offset = "0x1AE7608", VA = "0x7BBC2E7608")]
			internal bool <SetData>b__0(EPArchiveInfo x)
			{
				return default(bool);
			}

			// Token: 0x04007E10 RID: 32272
			[Token(Token = "0x4007E10")]
			[FieldOffset(Offset = "0x10")]
			public EPEventSettingData localData;
		}
	}
}
