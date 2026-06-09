using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A62 RID: 6754
	[Token(Token = "0x2001A62")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F812C", Offset = "0x10F812C")]
	public class UIMapModePopMenuItemController : UIPopMenuItemBaseController
	{
		// Token: 0x06008E2E RID: 36398 RVA: 0x00025F20 File Offset: 0x00024120
		[Token(Token = "0x6008E2E")]
		[Address(RVA = "0x146DBA0", Offset = "0x146DBA0", VA = "0x7BBBC6DBA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E2F RID: 36399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E2F")]
		[Address(RVA = "0x146DBF0", Offset = "0x146DBF0", VA = "0x7BBBC6DBF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E30")]
		[Address(RVA = "0x146DD50", Offset = "0x146DD50", VA = "0x7BBBC6DD50", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E31")]
		[Address(RVA = "0x146DE48", Offset = "0x146DE48", VA = "0x7BBBC6DE48", Slot = "28")]
		public override void SetItemData(PopMenuData data)
		{
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E32")]
		[Address(RVA = "0x146E000", Offset = "0x146E000", VA = "0x7BBBC6E000")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E33")]
		[Address(RVA = "0x146E048", Offset = "0x146E048", VA = "0x7BBBC6E048")]
		public void OnPopMenuItemClick()
		{
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E34")]
		[Address(RVA = "0x146E28C", Offset = "0x146E28C", VA = "0x7BBBC6E28C")]
		private void OnPopMenuSelected(params object[] data)
		{
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E35")]
		[Address(RVA = "0x146E398", Offset = "0x146E398", VA = "0x7BBBC6E398")]
		public UIMapModePopMenuItemController()
		{
		}

		// Token: 0x040099DB RID: 39387
		[Token(Token = "0x40099DB")]
		[FieldOffset(Offset = "0x60")]
		private UIMapModePopMeuItemView m_View;

		// Token: 0x040099DC RID: 39388
		[Token(Token = "0x40099DC")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;

		// Token: 0x040099DD RID: 39389
		[Token(Token = "0x40099DD")]
		[FieldOffset(Offset = "0x70")]
		private uint m_DelayCallID;

		// Token: 0x02001A63 RID: 6755
		[Token(Token = "0x2001A63")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8164", Offset = "0x10F8164")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008E37 RID: 36407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E37")]
			[Address(RVA = "0x146E404", Offset = "0x146E404", VA = "0x7BBBC6E404")]
			public <>c()
			{
			}

			// Token: 0x06008E38 RID: 36408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008E38")]
			[Address(RVA = "0x146E40C", Offset = "0x146E40C", VA = "0x7BBBC6E40C")]
			internal void <OnPopMenuItemClick>b__8_0()
			{
			}

			// Token: 0x040099DE RID: 39390
			[Token(Token = "0x40099DE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMapModePopMenuItemController.<>c <>9;

			// Token: 0x040099DF RID: 39391
			[Token(Token = "0x40099DF")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__8_0;
		}
	}
}
