using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018E1 RID: 6369
	[Token(Token = "0x20018E1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F510C", Offset = "0x10F510C")]
	internal class UIHudInGameShopCategoryController : UIBaseController
	{
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06007F33 RID: 32563 RVA: 0x00022BA8 File Offset: 0x00020DA8
		[Token(Token = "0x1700099B")]
		public int Category
		{
			[Token(Token = "0x6007F33")]
			[Address(RVA = "0x19874CC", Offset = "0x19874CC", VA = "0x7BBC1874CC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00022BC0 File Offset: 0x00020DC0
		[Token(Token = "0x6007F34")]
		[Address(RVA = "0x19874D4", Offset = "0x19874D4", VA = "0x7BBC1874D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F35")]
		[Address(RVA = "0x1987524", Offset = "0x1987524", VA = "0x7BBC187524", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F36")]
		[Address(RVA = "0x1987588", Offset = "0x1987588", VA = "0x7BBC187588")]
		public void SetUIData(uint category, List<oOu}}D^> itemList)
		{
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F37")]
		[Address(RVA = "0x1987984", Offset = "0x1987984", VA = "0x7BBC187984")]
		private void SetCategoryLabel(uint filter)
		{
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F38")]
		[Address(RVA = "0x1987CDC", Offset = "0x1987CDC", VA = "0x7BBC187CDC")]
		public UIHudInGameShopCategoryController()
		{
		}

		// Token: 0x04009232 RID: 37426
		[Token(Token = "0x4009232")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInGameShopCategoryView m_View;

		// Token: 0x04009233 RID: 37427
		[Token(Token = "0x4009233")]
		[FieldOffset(Offset = "0x60")]
		private int m_Category;

		// Token: 0x020018E2 RID: 6370
		[Token(Token = "0x20018E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F5144", Offset = "0x10F5144")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007F3A RID: 32570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F3A")]
			[Address(RVA = "0x1987D48", Offset = "0x1987D48", VA = "0x7BBC187D48")]
			public <>c()
			{
			}

			// Token: 0x06007F3B RID: 32571 RVA: 0x00022BD8 File Offset: 0x00020DD8
			[Token(Token = "0x6007F3B")]
			[Address(RVA = "0x1987D50", Offset = "0x1987D50", VA = "0x7BBC187D50")]
			internal int <SetUIData>b__6_0(Transform item1, Transform item2)
			{
				return 0;
			}

			// Token: 0x04009234 RID: 37428
			[Token(Token = "0x4009234")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudInGameShopCategoryController.<>c <>9;

			// Token: 0x04009235 RID: 37429
			[Token(Token = "0x4009235")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Transform> <>9__6_0;
		}
	}
}
