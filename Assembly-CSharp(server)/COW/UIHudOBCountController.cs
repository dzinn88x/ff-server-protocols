using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200191D RID: 6429
	[Token(Token = "0x200191D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F590C", Offset = "0x10F590C")]
	public class UIHudOBCountController : UIBaseController
	{
		// Token: 0x060081B9 RID: 33209 RVA: 0x000235F8 File Offset: 0x000217F8
		[Token(Token = "0x60081B9")]
		[Address(RVA = "0x17BB648", Offset = "0x17BB648", VA = "0x7BBBFBB648")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081BA")]
		[Address(RVA = "0x17BB698", Offset = "0x17BB698", VA = "0x7BBBFBB698", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081BB")]
		[Address(RVA = "0x17BB928", Offset = "0x17BB928", VA = "0x7BBBFBB928")]
		private void UpdateCount(int count)
		{
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081BC")]
		[Address(RVA = "0x17BBA18", Offset = "0x17BBA18", VA = "0x7BBBFBBA18")]
		private void OnOBCountChange(params object[] data)
		{
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081BD")]
		[Address(RVA = "0x17BBB68", Offset = "0x17BBB68", VA = "0x7BBBFBBB68")]
		private void OnStreamerOBCountChange(params object[] data)
		{
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081BE")]
		[Address(RVA = "0x17BBDAC", Offset = "0x17BBDAC", VA = "0x7BBBFBBDAC")]
		private void OnOBTargetChange(params object[] data)
		{
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081BF")]
		[Address(RVA = "0x17BBF90", Offset = "0x17BBF90", VA = "0x7BBBFBBF90")]
		private void OnLikeCountChanged(params object[] data)
		{
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C0")]
		[Address(RVA = "0x17BC04C", Offset = "0x17BC04C", VA = "0x7BBBFBC04C")]
		private void OnPopFinished()
		{
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C1")]
		[Address(RVA = "0x17BC0DC", Offset = "0x17BC0DC", VA = "0x7BBBFBC0DC")]
		private void OnGameStreamerSkillActive(params object[] data)
		{
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C2")]
		[Address(RVA = "0x17BC1B4", Offset = "0x17BC1B4", VA = "0x7BBBFBC1B4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C3")]
		[Address(RVA = "0x17BC3C4", Offset = "0x17BC3C4", VA = "0x7BBBFBC3C4")]
		public UIHudOBCountController()
		{
		}

		// Token: 0x04009350 RID: 37712
		[Token(Token = "0x4009350")]
		[FieldOffset(Offset = "0x58")]
		private UIHudOBCountView m_View;

		// Token: 0x04009351 RID: 37713
		[Token(Token = "0x4009351")]
		[FieldOffset(Offset = "0x60")]
		private int m_Count;

		// Token: 0x04009352 RID: 37714
		[Token(Token = "0x4009352")]
		[FieldOffset(Offset = "0x64")]
		private int m_LikedInqueueCount;
	}
}
