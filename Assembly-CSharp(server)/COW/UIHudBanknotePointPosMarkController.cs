using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001876 RID: 6262
	[Token(Token = "0x2001876")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4264", Offset = "0x10F4264")]
	public class UIHudBanknotePointPosMarkController : UIHudNameBaseController
	{
		// Token: 0x06007BB7 RID: 31671 RVA: 0x00021FC0 File Offset: 0x000201C0
		[Token(Token = "0x6007BB7")]
		[Address(RVA = "0x18907F8", Offset = "0x18907F8", VA = "0x7BBC0907F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB8")]
		[Address(RVA = "0x1890848", Offset = "0x1890848", VA = "0x7BBC090848", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB9")]
		[Address(RVA = "0x1890C20", Offset = "0x1890C20", VA = "0x7BBC090C20", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x00021FD8 File Offset: 0x000201D8
		[Token(Token = "0x6007BBA")]
		[Address(RVA = "0x1890D94", Offset = "0x1890D94", VA = "0x7BBC090D94", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x00021FF0 File Offset: 0x000201F0
		[Token(Token = "0x6007BBB")]
		[Address(RVA = "0x1890E3C", Offset = "0x1890E3C", VA = "0x7BBC090E3C", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x00022008 File Offset: 0x00020208
		[Token(Token = "0x6007BBC")]
		[Address(RVA = "0x1890E44", Offset = "0x1890E44", VA = "0x7BBC090E44", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00022020 File Offset: 0x00020220
		[Token(Token = "0x6007BBD")]
		[Address(RVA = "0x1890F64", Offset = "0x1890F64", VA = "0x7BBC090F64", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BBE")]
		[Address(RVA = "0x1890F6C", Offset = "0x1890F6C", VA = "0x7BBC090F6C")]
		private void OnOccupateTeamChange(object[] data)
		{
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BBF")]
		[Address(RVA = "0x18911A4", Offset = "0x18911A4", VA = "0x7BBC0911A4")]
		private void OnRestAmountChange(object[] data)
		{
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC0")]
		[Address(RVA = "0x1891274", Offset = "0x1891274", VA = "0x7BBC091274")]
		private void OnControlPointChange(object[] data)
		{
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC1")]
		[Address(RVA = "0x1890AC8", Offset = "0x1890AC8", VA = "0x7BBC090AC8")]
		private void ClearHudShow()
		{
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC2")]
		[Address(RVA = "0x1891530", Offset = "0x1891530", VA = "0x7BBC091530")]
		public UIHudBanknotePointPosMarkController()
		{
		}

		// Token: 0x04009014 RID: 36884
		[Token(Token = "0x4009014")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudBanknotePointPosMarkView m_View;

		// Token: 0x04009015 RID: 36885
		[Token(Token = "0x4009015")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_ControlPointPos;

		// Token: 0x04009016 RID: 36886
		[Token(Token = "0x4009016")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_CurrentPointID;

		// Token: 0x04009017 RID: 36887
		[Token(Token = "0x4009017")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04009018 RID: 36888
		[Token(Token = "0x4009018")]
		private const int NO_OCCUPY_COLOR = 2130706517;

		// Token: 0x04009019 RID: 36889
		[Token(Token = "0x4009019")]
		private const int LOCAL_OCCUPY_COLOR = 2131790519;

		// Token: 0x0400901A RID: 36890
		[Token(Token = "0x400901A")]
		private const int OPP_OCCUPY_COLOR = 2145343516;
	}
}
