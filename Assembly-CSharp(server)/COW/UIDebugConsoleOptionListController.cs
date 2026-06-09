using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014DF RID: 5343
	[Token(Token = "0x20014DF")]
	public class UIDebugConsoleOptionListController : UIBaseController, IEasyList
	{
		// Token: 0x06005B51 RID: 23377 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[Token(Token = "0x6005B51")]
		[Address(RVA = "0x1BB93CC", Offset = "0x1BB93CC", VA = "0x7BBC3B93CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x1BB941C", Offset = "0x1BB941C", VA = "0x7BBC3B941C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x1BB94AC", Offset = "0x1BB94AC", VA = "0x7BBC3B94AC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x1BB795C", Offset = "0x1BB795C", VA = "0x7BBC3B795C")]
		public void InitData(List<string> options, Action<string> handler)
		{
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B55")]
		[Address(RVA = "0x1BB94B4", Offset = "0x1BB94B4", VA = "0x7BBC3B94B4")]
		public void OnOptionSelect(string option)
		{
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B56")]
		[Address(RVA = "0x1BB9528", Offset = "0x1BB9528", VA = "0x7BBC3B9528", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x1BB95D4", Offset = "0x1BB95D4", VA = "0x7BBC3B95D4", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x1BB9604", Offset = "0x1BB9604", VA = "0x7BBC3B9604")]
		public UIDebugConsoleOptionListController()
		{
		}

		// Token: 0x04007DF2 RID: 32242
		[Token(Token = "0x4007DF2")]
		[FieldOffset(Offset = "0x58")]
		private UIDebugConsoleOptionListView m_View;

		// Token: 0x04007DF3 RID: 32243
		[Token(Token = "0x4007DF3")]
		[FieldOffset(Offset = "0x60")]
		private Action<string> m_OptionHandler;
	}
}
