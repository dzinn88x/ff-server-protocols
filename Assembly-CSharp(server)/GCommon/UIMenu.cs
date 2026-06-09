using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200102D RID: 4141
	[Token(Token = "0x200102D")]
	public class UIMenu : MonoBehaviour
	{
		// Token: 0x06003EBF RID: 16063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x202EF24", Offset = "0x202EF24", VA = "0x7BBC82EF24")]
		private void Awake()
		{
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC0")]
		[Address(RVA = "0x202EFF8", Offset = "0x202EFF8", VA = "0x7BBC82EFF8")]
		private void Start()
		{
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC1")]
		[Address(RVA = "0x202EFFC", Offset = "0x202EFFC", VA = "0x7BBC82EFFC")]
		private void Update()
		{
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC2")]
		[Address(RVA = "0x202F000", Offset = "0x202F000", VA = "0x7BBC82F000")]
		private void OnEnable()
		{
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC3")]
		[Address(RVA = "0x202F108", Offset = "0x202F108", VA = "0x7BBC82F108")]
		public void AddMenu(UIMenuItemData menuData)
		{
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC4")]
		[Address(RVA = "0x202F4DC", Offset = "0x202F4DC", VA = "0x7BBC82F4DC")]
		public void Build(string selectID = "")
		{
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x202F89C", Offset = "0x202F89C", VA = "0x7BBC82F89C")]
		public void TrySelectByID(string id)
		{
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x202FAA0", Offset = "0x202FAA0", VA = "0x7BBC82FAA0")]
		public UIMenuItem FindMenuItemByID(string id)
		{
			return null;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x202FB78", Offset = "0x202FB78", VA = "0x7BBC82FB78")]
		public void Clear()
		{
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x202F508", Offset = "0x202F508", VA = "0x7BBC82F508")]
		public void Reposion()
		{
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x202F9E8", Offset = "0x202F9E8", VA = "0x7BBC82F9E8")]
		private void OnMenuSelected(UIMenuItem selectMenu)
		{
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x202FF24", Offset = "0x202FF24", VA = "0x7BBC82FF24")]
		public static Vector3 LocalPositionSetY(Transform target, float y)
		{
			return default(Vector3);
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x202FE7C", Offset = "0x202FE7C", VA = "0x7BBC82FE7C")]
		public static Vector3 LocalPositionSetX(Transform target, float x)
		{
			return default(Vector3);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x202FFCC", Offset = "0x202FFCC", VA = "0x7BBC82FFCC")]
		public UIMenu()
		{
		}

		// Token: 0x04004F05 RID: 20229
		[Token(Token = "0x4004F05")]
		[FieldOffset(Offset = "0x18")]
		public UIMenuItem menuTemplate;

		// Token: 0x04004F06 RID: 20230
		[Token(Token = "0x4004F06")]
		[FieldOffset(Offset = "0x20")]
		public UIMenu.Pivot pivot;

		// Token: 0x04004F07 RID: 20231
		[Token(Token = "0x4004F07")]
		[FieldOffset(Offset = "0x24")]
		public float space;

		// Token: 0x04004F08 RID: 20232
		[Token(Token = "0x4004F08")]
		[FieldOffset(Offset = "0x28")]
		public bool exActiveAsClick;

		// Token: 0x04004F09 RID: 20233
		[Token(Token = "0x4004F09")]
		[FieldOffset(Offset = "0x30")]
		private List<UIMenuItem> m_Menus;

		// Token: 0x04004F0A RID: 20234
		[Token(Token = "0x4004F0A")]
		[FieldOffset(Offset = "0x38")]
		private UIMenuItem m_SelectedMenu;

		// Token: 0x0200102E RID: 4142
		[Token(Token = "0x200102E")]
		public enum Pivot
		{
			// Token: 0x04004F0C RID: 20236
			[Token(Token = "0x4004F0C")]
			HorizontalCenter,
			// Token: 0x04004F0D RID: 20237
			[Token(Token = "0x4004F0D")]
			RightToLeft,
			// Token: 0x04004F0E RID: 20238
			[Token(Token = "0x4004F0E")]
			LeftToRight,
			// Token: 0x04004F0F RID: 20239
			[Token(Token = "0x4004F0F")]
			TopToBottom
		}

		// Token: 0x0200102F RID: 4143
		[Token(Token = "0x200102F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA764", Offset = "0x10EA764")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003ECD RID: 16077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ECD")]
			[Address(RVA = "0x202F9E0", Offset = "0x202F9E0", VA = "0x7BBC82F9E0")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06003ECE RID: 16078 RVA: 0x000137B8 File Offset: 0x000119B8
			[Token(Token = "0x6003ECE")]
			[Address(RVA = "0x203003C", Offset = "0x203003C", VA = "0x7BBC83003C")]
			internal bool <TrySelectByID>b__0(UIMenuItem e)
			{
				return default(bool);
			}

			// Token: 0x04004F10 RID: 20240
			[Token(Token = "0x4004F10")]
			[FieldOffset(Offset = "0x10")]
			public string id;
		}

		// Token: 0x02001030 RID: 4144
		[Token(Token = "0x2001030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA774", Offset = "0x10EA774")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06003ECF RID: 16079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003ECF")]
			[Address(RVA = "0x202FB70", Offset = "0x202FB70", VA = "0x7BBC82FB70")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06003ED0 RID: 16080 RVA: 0x000137D0 File Offset: 0x000119D0
			[Token(Token = "0x6003ED0")]
			[Address(RVA = "0x20300E8", Offset = "0x20300E8", VA = "0x7BBC8300E8")]
			internal bool <FindMenuItemByID>b__0(UIMenuItem e)
			{
				return default(bool);
			}

			// Token: 0x04004F11 RID: 20241
			[Token(Token = "0x4004F11")]
			[FieldOffset(Offset = "0x10")]
			public string id;
		}
	}
}
