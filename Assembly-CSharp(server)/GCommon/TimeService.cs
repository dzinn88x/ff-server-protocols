using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ED3 RID: 3795
	[Token(Token = "0x2000ED3")]
	public class TimeService
	{
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x17000692")]
		public float GameTime
		{
			[Token(Token = "0x6003473")]
			[Address(RVA = "0x2498F98", Offset = "0x2498F98", VA = "0x7BBCC98F98")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x17000693")]
		public float LastGameTime
		{
			[Token(Token = "0x6003474")]
			[Address(RVA = "0x2498FA0", Offset = "0x2498FA0", VA = "0x7BBCC98FA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x17000694")]
		public float FixedDeltaTime
		{
			[Token(Token = "0x6003475")]
			[Address(RVA = "0x2498FA8", Offset = "0x2498FA8", VA = "0x7BBCC98FA8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x17000695")]
		public float DeltaTime
		{
			[Token(Token = "0x6003476")]
			[Address(RVA = "0x2498FB0", Offset = "0x2498FB0", VA = "0x7BBCC98FB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x0000FB28 File Offset: 0x0000DD28
		[Token(Token = "0x17000696")]
		public uint DeltaTickCount
		{
			[Token(Token = "0x6003477")]
			[Address(RVA = "0x2498FB8", Offset = "0x2498FB8", VA = "0x7BBCC98FB8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[Token(Token = "0x17000697")]
		public uint TickCount
		{
			[Token(Token = "0x6003478")]
			[Address(RVA = "0x2498FC0", Offset = "0x2498FC0", VA = "0x7BBCC98FC0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x2498FC8", Offset = "0x2498FC8", VA = "0x7BBCC98FC8")]
		public void Reset()
		{
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x2498FD4", Offset = "0x2498FD4", VA = "0x7BBCC98FD4")]
		public void UseFixedDeltaTime(float fixedDeltaTime)
		{
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x2498FE4", Offset = "0x2498FE4", VA = "0x7BBCC98FE4")]
		public void UpdateTime()
		{
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x2499070", Offset = "0x2499070", VA = "0x7BBCC99070")]
		public void ClearDeltaTime()
		{
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x2499078", Offset = "0x2499078", VA = "0x7BBCC99078")]
		public TimeService()
		{
		}

		// Token: 0x04004813 RID: 18451
		[Token(Token = "0x4004813")]
		[FieldOffset(Offset = "0x10")]
		private float m_GameTime;

		// Token: 0x04004814 RID: 18452
		[Token(Token = "0x4004814")]
		[FieldOffset(Offset = "0x14")]
		private float m_LastGameTime;

		// Token: 0x04004815 RID: 18453
		[Token(Token = "0x4004815")]
		[FieldOffset(Offset = "0x18")]
		private float m_DeltaTime;

		// Token: 0x04004816 RID: 18454
		[Token(Token = "0x4004816")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_DeltaTickCount;

		// Token: 0x04004817 RID: 18455
		[Token(Token = "0x4004817")]
		[FieldOffset(Offset = "0x20")]
		private uint m_TickCount;

		// Token: 0x04004818 RID: 18456
		[Token(Token = "0x4004818")]
		[FieldOffset(Offset = "0x24")]
		private bool m_UsingFixedDeltaTime;

		// Token: 0x04004819 RID: 18457
		[Token(Token = "0x4004819")]
		[FieldOffset(Offset = "0x28")]
		private float m_FixedDeltaTime;
	}
}
