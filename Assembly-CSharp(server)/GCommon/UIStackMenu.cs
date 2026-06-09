using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200103D RID: 4157
	[Token(Token = "0x200103D")]
	public class UIStackMenu : MonoBehaviour
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x2235754", Offset = "0x2235754", VA = "0x7BBCA35754")]
		private void Awake()
		{
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x22357DC", Offset = "0x22357DC", VA = "0x7BBCA357DC")]
		private void Start()
		{
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F52")]
		[Address(RVA = "0x22357E0", Offset = "0x22357E0", VA = "0x7BBCA357E0")]
		private void Update()
		{
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x22357E4", Offset = "0x22357E4", VA = "0x7BBCA357E4")]
		public void AddMenu(UIMenuItemData mainMenu, List<UIMenuItemData> subMenu)
		{
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x2235C44", Offset = "0x2235C44", VA = "0x7BBCA35C44")]
		public void Build([Optional] string selectMainID, [Optional] string selectSubID)
		{
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x2235C48", Offset = "0x2235C48", VA = "0x7BBCA35C48")]
		public void TrySelectByID(string mainID, string subID)
		{
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x2235F98", Offset = "0x2235F98", VA = "0x7BBCA35F98")]
		public void Clear()
		{
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x2235DA4", Offset = "0x2235DA4", VA = "0x7BBCA35DA4")]
		public void OnMainMenuSelected(UIMenuItem menuUI)
		{
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x2236234", Offset = "0x2236234", VA = "0x7BBCA36234")]
		public void OnSubMenuSelected(UIMenuItem menuUI)
		{
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x22362F4", Offset = "0x22362F4", VA = "0x7BBCA362F4")]
		public void Reposion()
		{
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x2235988", Offset = "0x2235988", VA = "0x7BBCA35988")]
		public UIMenuItem CreateMainMenu(UIMenuItemData menu)
		{
			return null;
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x2235ABC", Offset = "0x2235ABC", VA = "0x7BBCA35ABC")]
		public UIMenuItem CreateSubMenu(UIMenuItemData subMenu, UIMenuItem mainMenuUI)
		{
			return null;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00013A58 File Offset: 0x00011C58
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x2236614", Offset = "0x2236614", VA = "0x7BBCA36614")]
		public static Vector3 LocalPositionSetY(Transform target, float y)
		{
			return default(Vector3);
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x22366BC", Offset = "0x22366BC", VA = "0x7BBCA366BC")]
		public static Vector3 LocalPositionSetX(Transform target, float x)
		{
			return default(Vector3);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x2236764", Offset = "0x2236764", VA = "0x7BBCA36764")]
		public UIStackMenu()
		{
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x22367FC", Offset = "0x22367FC", VA = "0x7BBCA367FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C22C", Offset = "0x113C22C")]
		private bool <OnMainMenuSelected>b__15_0(UIMenuItem e)
		{
			return default(bool);
		}

		// Token: 0x04004F64 RID: 20324
		[Token(Token = "0x4004F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIMenuItem mainMenuTemplate;

		// Token: 0x04004F65 RID: 20325
		[Token(Token = "0x4004F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIMenuItem subMenuTeamplate;

		// Token: 0x04004F66 RID: 20326
		[Token(Token = "0x4004F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform menuRootPoint;

		// Token: 0x04004F67 RID: 20327
		[Token(Token = "0x4004F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<UIMenuItem> m_MainMenus;

		// Token: 0x04004F68 RID: 20328
		[Token(Token = "0x4004F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<UIMenuItem, List<UIMenuItem>> m_Menus;

		// Token: 0x04004F69 RID: 20329
		[Token(Token = "0x4004F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIMenuItem m_SelectedMainMenu;

		// Token: 0x04004F6A RID: 20330
		[Token(Token = "0x4004F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UIMenuItem m_SelectedSubMenu;

		// Token: 0x04004F6B RID: 20331
		[Token(Token = "0x4004F6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string m_TrySelectSubMenuID;

		// Token: 0x0200103E RID: 4158
		[Token(Token = "0x200103E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA9C4", Offset = "0x10EA9C4")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003F60 RID: 16224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F60")]
			[Address(RVA = "0x2235D9C", Offset = "0x2235D9C", VA = "0x7BBCA35D9C")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06003F61 RID: 16225 RVA: 0x00013AA0 File Offset: 0x00011CA0
			[Token(Token = "0x6003F61")]
			[Address(RVA = "0x2236834", Offset = "0x2236834", VA = "0x7BBCA36834")]
			internal bool <TrySelectByID>b__0(UIMenuItem e)
			{
				return default(bool);
			}

			// Token: 0x04004F6C RID: 20332
			[Token(Token = "0x4004F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string mainID;
		}
	}
}
