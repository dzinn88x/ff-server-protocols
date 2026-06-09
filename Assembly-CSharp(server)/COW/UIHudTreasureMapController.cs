using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001982 RID: 6530
	[Token(Token = "0x2001982")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F667C", Offset = "0x10F667C")]
	internal class UIHudTreasureMapController : UIHudButtonBaseController
	{
		// Token: 0x06008512 RID: 34066 RVA: 0x00024150 File Offset: 0x00022350
		[Token(Token = "0x6008512")]
		[Address(RVA = "0x15EA560", Offset = "0x15EA560", VA = "0x7BBBDEA560")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008513 RID: 34067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008513")]
		[Address(RVA = "0x15EA5B0", Offset = "0x15EA5B0", VA = "0x7BBBDEA5B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008514")]
		[Address(RVA = "0x15EA76C", Offset = "0x15EA76C", VA = "0x7BBBDEA76C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008515")]
		[Address(RVA = "0x15EA8E0", Offset = "0x15EA8E0", VA = "0x7BBBDEA8E0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008516")]
		[Address(RVA = "0x15EA928", Offset = "0x15EA928", VA = "0x7BBBDEA928")]
		private void ShowTreasureMapIcon(params object[] param)
		{
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x00024168 File Offset: 0x00022368
		[Token(Token = "0x6008517")]
		[Address(RVA = "0x15EAB40", Offset = "0x15EAB40", VA = "0x7BBBDEAB40")]
		private bool ShouldShow()
		{
			return default(bool);
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008518")]
		[Address(RVA = "0x15EACBC", Offset = "0x15EACBC", VA = "0x7BBBDEACBC")]
		private void OnUpdateLoadoutCount(params object[] param)
		{
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008519")]
		[Address(RVA = "0x15EAE28", Offset = "0x15EAE28", VA = "0x7BBBDEAE28")]
		private void OnGameOpenningEnd(params object[] param)
		{
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600851A")]
		[Address(RVA = "0x15EAF10", Offset = "0x15EAF10", VA = "0x7BBBDEAF10")]
		private void ShowTutorial()
		{
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600851B")]
		[Address(RVA = "0x15EB04C", Offset = "0x15EB04C", VA = "0x7BBBDEB04C")]
		public UIHudTreasureMapController()
		{
		}

		// Token: 0x040094E2 RID: 38114
		[Token(Token = "0x40094E2")]
		[FieldOffset(Offset = "0x60")]
		private UIHudTreasureMapView m_View;

		// Token: 0x040094E3 RID: 38115
		[Token(Token = "0x40094E3")]
		[FieldOffset(Offset = "0x68")]
		private bool needShow;

		// Token: 0x040094E4 RID: 38116
		[Token(Token = "0x40094E4")]
		[FieldOffset(Offset = "0x69")]
		private bool HasShownTutorial;
	}
}
