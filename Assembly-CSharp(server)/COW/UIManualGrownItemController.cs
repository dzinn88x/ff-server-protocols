using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A3D RID: 6717
	[Token(Token = "0x2001A3D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7D44", Offset = "0x10F7D44")]
	public class UIManualGrownItemController : UIBaseController
	{
		// Token: 0x06008D29 RID: 36137 RVA: 0x00025A58 File Offset: 0x00023C58
		[Token(Token = "0x6008D29")]
		[Address(RVA = "0x1DF92EC", Offset = "0x1DF92EC", VA = "0x7BBC5F92EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D2A")]
		[Address(RVA = "0x1DF933C", Offset = "0x1DF933C", VA = "0x7BBC5F933C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D2B")]
		[Address(RVA = "0x1DF9920", Offset = "0x1DF9920", VA = "0x7BBC5F9920", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008D2C RID: 36140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D2C")]
		[Address(RVA = "0x1DF9928", Offset = "0x1DF9928", VA = "0x7BBC5F9928", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D2D")]
		[Address(RVA = "0x1DF9930", Offset = "0x1DF9930", VA = "0x7BBC5F9930")]
		public void SetData(BaseItemInfo data)
		{
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D2E")]
		[Address(RVA = "0x1DF9938", Offset = "0x1DF9938", VA = "0x7BBC5F9938")]
		public void RefreshView(UIManualGrownItemGroupController.State state)
		{
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D2F")]
		[Address(RVA = "0x1DF99B8", Offset = "0x1DF99B8", VA = "0x7BBC5F99B8")]
		private void DoShowView(UIManualGrownItemGroupController.State state)
		{
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D30")]
		[Address(RVA = "0x1DF9428", Offset = "0x1DF9428", VA = "0x7BBC5F9428")]
		private void InitIconList()
		{
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D31")]
		[Address(RVA = "0x1DF9B44", Offset = "0x1DF9B44", VA = "0x7BBC5F9B44")]
		private void SetIconColor(Color color)
		{
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D32")]
		[Address(RVA = "0x1DF9CD4", Offset = "0x1DF9CD4", VA = "0x7BBC5F9CD4")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D33")]
		[Address(RVA = "0x1DF9DB8", Offset = "0x1DF9DB8", VA = "0x7BBC5F9DB8")]
		public UIManualGrownItemController()
		{
		}

		// Token: 0x0400994A RID: 39242
		[Token(Token = "0x400994A")]
		[FieldOffset(Offset = "0x58")]
		private UIManualGrownItemView m_View;

		// Token: 0x0400994B RID: 39243
		[Token(Token = "0x400994B")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_Data;

		// Token: 0x0400994C RID: 39244
		[Token(Token = "0x400994C")]
		[FieldOffset(Offset = "0x68")]
		private List<UISprite> m_IconList;

		// Token: 0x0400994D RID: 39245
		[Token(Token = "0x400994D")]
		[FieldOffset(Offset = "0x70")]
		private readonly uint DISABLE_COLOR;
	}
}
