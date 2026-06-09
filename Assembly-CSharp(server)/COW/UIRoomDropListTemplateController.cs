using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B5F RID: 7007
	[Token(Token = "0x2001B5F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9E34", Offset = "0x10F9E34")]
	public class UIRoomDropListTemplateController : UIBaseController
	{
		// Token: 0x060096A5 RID: 38565 RVA: 0x00027D08 File Offset: 0x00025F08
		[Token(Token = "0x60096A5")]
		[Address(RVA = "0x1E23360", Offset = "0x1E23360", VA = "0x7BBC623360")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A6")]
		[Address(RVA = "0x1E233B0", Offset = "0x1E233B0", VA = "0x7BBC6233B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A7")]
		[Address(RVA = "0x1E23494", Offset = "0x1E23494", VA = "0x7BBC623494", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A8")]
		[Address(RVA = "0x1E234BC", Offset = "0x1E234BC", VA = "0x7BBC6234BC")]
		public void SetDropListInfo(string labelTxt, UIRoomDropListTemplateController.OnDropBtnClick callback, float maxCnt = 4.5f)
		{
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A9")]
		[Address(RVA = "0x1E236A0", Offset = "0x1E236A0", VA = "0x7BBC6236A0")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096AA")]
		[Address(RVA = "0x1E236E0", Offset = "0x1E236E0", VA = "0x7BBC6236E0")]
		public void SetDropListDepth(int depth)
		{
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096AB")]
		[Address(RVA = "0x1E23724", Offset = "0x1E23724", VA = "0x7BBC623724")]
		public void SetSelectedText(string txt)
		{
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096AC")]
		protected override T OpenChildController<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
		{
			return null;
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096AD")]
		[Address(RVA = "0x1E2384C", Offset = "0x1E2384C", VA = "0x7BBC62384C")]
		public UIRoomDropListTemplateController()
		{
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096AE")]
		[Address(RVA = "0x1E23854", Offset = "0x1E23854", VA = "0x7BBC623854")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144CC0", Offset = "0x1144CC0")]
		private void <SetDropListInfo>b__8_0()
		{
		}

		// Token: 0x04009F23 RID: 40739
		[Token(Token = "0x4009F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIRoomDropListTemplateView m_View;

		// Token: 0x04009F24 RID: 40740
		[Token(Token = "0x4009F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIRoomDropListTemplateController.OnDropBtnClick m_OnDropBtnClickCallback;

		// Token: 0x04009F25 RID: 40741
		[Token(Token = "0x4009F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIPopMenuSmallControler m_PopMenuSmallControler;

		// Token: 0x04009F26 RID: 40742
		[Token(Token = "0x4009F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_BaseDepth;

		// Token: 0x02001B60 RID: 7008
		// (Invoke) Token: 0x060096B0 RID: 38576
		[Token(Token = "0x2001B60")]
		public delegate List<PopMenuData> OnDropBtnClick();
	}
}
