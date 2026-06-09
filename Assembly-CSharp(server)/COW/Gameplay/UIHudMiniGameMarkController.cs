using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B78 RID: 11128
	[Token(Token = "0x2002B78")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FF2BC", Offset = "0x10FF2BC")]
	public class UIHudMiniGameMarkController : UIHudNameBaseController
	{
		// Token: 0x0600F5F4 RID: 62964 RVA: 0x00046A40 File Offset: 0x00044C40
		[Token(Token = "0x600F5F4")]
		[Address(RVA = "0x16D2DCC", Offset = "0x16D2DCC", VA = "0x7BBBED2DCC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600F5F5 RID: 62965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5F5")]
		[Address(RVA = "0x16D2E1C", Offset = "0x16D2E1C", VA = "0x7BBBED2E1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600F5F6 RID: 62966 RVA: 0x00046A58 File Offset: 0x00044C58
		[Token(Token = "0x600F5F6")]
		[Address(RVA = "0x16D2F0C", Offset = "0x16D2F0C", VA = "0x7BBBED2F0C", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x0600F5F7 RID: 62967 RVA: 0x00046A70 File Offset: 0x00044C70
		[Token(Token = "0x600F5F7")]
		[Address(RVA = "0x16D2F14", Offset = "0x16D2F14", VA = "0x7BBBED2F14", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x0600F5F8 RID: 62968 RVA: 0x00046A88 File Offset: 0x00044C88
		[Token(Token = "0x600F5F8")]
		[Address(RVA = "0x16D2FB0", Offset = "0x16D2FB0", VA = "0x7BBBED2FB0", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600F5F9 RID: 62969 RVA: 0x00046AA0 File Offset: 0x00044CA0
		[Token(Token = "0x600F5F9")]
		[Address(RVA = "0x16D30EC", Offset = "0x16D30EC", VA = "0x7BBBED30EC", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x0600F5FA RID: 62970 RVA: 0x00046AB8 File Offset: 0x00044CB8
		[Token(Token = "0x600F5FA")]
		[Address(RVA = "0x16D3128", Offset = "0x16D3128", VA = "0x7BBBED3128", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x0600F5FB RID: 62971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5FB")]
		[Address(RVA = "0x16D3130", Offset = "0x16D3130", VA = "0x7BBBED3130")]
		public void BindPlayerAndWorldPosition(Vector3 sHZHHsw)
		{
		}

		// Token: 0x0600F5FC RID: 62972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5FC")]
		[Address(RVA = "0x16D313C", Offset = "0x16D313C", VA = "0x7BBBED313C")]
		public void SetViewData(ZykjDpa apKxpV\u0080)
		{
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5FD")]
		[Address(RVA = "0x16D34D8", Offset = "0x16D34D8", VA = "0x7BBBED34D8")]
		public UIHudMiniGameMarkController()
		{
		}

		// Token: 0x04011A5F RID: 72287
		[Token(Token = "0x4011A5F")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudItemMarkShowView p|r\u007Fnuf;

		// Token: 0x04011A60 RID: 72288
		[Token(Token = "0x4011A60")]
		private const float \u0082C = 1f;

		// Token: 0x04011A61 RID: 72289
		[Token(Token = "0x4011A61")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 GlBSp;
	}
}
