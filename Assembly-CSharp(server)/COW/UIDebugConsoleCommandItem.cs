using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014D1 RID: 5329
	[Token(Token = "0x20014D1")]
	public class UIDebugConsoleCommandItem : UIBaseController, UITable2.IUITable2Item
	{
		// Token: 0x06005AFE RID: 23294 RVA: 0x0001AA78 File Offset: 0x00018C78
		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0x1BB0610", Offset = "0x1BB0610", VA = "0x7BBC3B0610")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0x1BB0660", Offset = "0x1BB0660", VA = "0x7BBC3B0660", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0x1BB0744", Offset = "0x1BB0744", VA = "0x7BBC3B0744", Slot = "28")]
		public object SetTable2ItemData(int index, object data, object viewState)
		{
			return null;
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B01")]
		[Address(RVA = "0x1BB081C", Offset = "0x1BB081C", VA = "0x7BBC3B081C", Slot = "29")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B02")]
		[Address(RVA = "0x1BB08E4", Offset = "0x1BB08E4", VA = "0x7BBC3B08E4", Slot = "30")]
		public void SetTable2Visible(bool visible)
		{
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B03")]
		[Address(RVA = "0x1BB0920", Offset = "0x1BB0920", VA = "0x7BBC3B0920")]
		private void OnCmdClick()
		{
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B04")]
		[Address(RVA = "0x1BB1070", Offset = "0x1BB1070", VA = "0x7BBC3B1070")]
		public UIDebugConsoleCommandItem()
		{
		}

		// Token: 0x04007DB6 RID: 32182
		[Token(Token = "0x4007DB6")]
		[FieldOffset(Offset = "0x58")]
		private UIDebugConsoleCommandItemView m_View;

		// Token: 0x04007DB7 RID: 32183
		[Token(Token = "0x4007DB7")]
		[FieldOffset(Offset = "0x60")]
		private UIDebugConsoleCommandItem.Data m_Data;

		// Token: 0x04007DB8 RID: 32184
		[Token(Token = "0x4007DB8")]
		[FieldOffset(Offset = "0x68")]
		public UIDebugConsoleCommandItem.OnRunCmd OnRunCmdHandler;

		// Token: 0x020014D2 RID: 5330
		[Token(Token = "0x20014D2")]
		public class Data
		{
			// Token: 0x06005B05 RID: 23301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B05")]
			[Address(RVA = "0x1BB1078", Offset = "0x1BB1078", VA = "0x7BBC3B1078")]
			public Data()
			{
			}

			// Token: 0x04007DB9 RID: 32185
			[Token(Token = "0x4007DB9")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04007DBA RID: 32186
			[Token(Token = "0x4007DBA")]
			[FieldOffset(Offset = "0x18")]
			public string cmd;
		}

		// Token: 0x020014D3 RID: 5331
		// (Invoke) Token: 0x06005B07 RID: 23303
		[Token(Token = "0x20014D3")]
		public delegate void OnRunCmd(string cmd);
	}
}
