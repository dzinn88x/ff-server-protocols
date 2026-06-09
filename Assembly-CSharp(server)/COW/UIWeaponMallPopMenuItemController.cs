using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015C6 RID: 5574
	[Token(Token = "0x20015C6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF2D4", Offset = "0x10EF2D4")]
	public class UIWeaponMallPopMenuItemController : UIPopMenuItemBaseController
	{
		// Token: 0x060062C8 RID: 25288 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		[Token(Token = "0x60062C8")]
		[Address(RVA = "0x1690C04", Offset = "0x1690C04", VA = "0x7BBBE90C04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C9")]
		[Address(RVA = "0x1690C54", Offset = "0x1690C54", VA = "0x7BBBE90C54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CA")]
		[Address(RVA = "0x1690D38", Offset = "0x1690D38", VA = "0x7BBBE90D38", Slot = "29")]
		public override void SetItemData(PopMenuData data, int CellWidth, int CellHeight)
		{
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CB")]
		[Address(RVA = "0x1690F60", Offset = "0x1690F60", VA = "0x7BBBE90F60")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0x1690FA8", Offset = "0x1690FA8", VA = "0x7BBBE90FA8")]
		public void OnPopMenuItemClick()
		{
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CD")]
		[Address(RVA = "0x1691148", Offset = "0x1691148", VA = "0x7BBBE91148")]
		public UIWeaponMallPopMenuItemController()
		{
		}

		// Token: 0x040081CA RID: 33226
		[Token(Token = "0x40081CA")]
		[FieldOffset(Offset = "0x60")]
		private UICollectionPopMeuItemView m_View;

		// Token: 0x040081CB RID: 33227
		[Token(Token = "0x40081CB")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;

		// Token: 0x020015C7 RID: 5575
		[Token(Token = "0x20015C7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF30C", Offset = "0x10EF30C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060062CF RID: 25295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CF")]
			[Address(RVA = "0x16911B4", Offset = "0x16911B4", VA = "0x7BBBE911B4")]
			public <>c()
			{
			}

			// Token: 0x060062D0 RID: 25296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D0")]
			[Address(RVA = "0x16911BC", Offset = "0x16911BC", VA = "0x7BBBE911BC")]
			internal void <OnPopMenuItemClick>b__6_0()
			{
			}

			// Token: 0x040081CC RID: 33228
			[Token(Token = "0x40081CC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIWeaponMallPopMenuItemController.<>c <>9;

			// Token: 0x040081CD RID: 33229
			[Token(Token = "0x40081CD")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__6_0;
		}
	}
}
