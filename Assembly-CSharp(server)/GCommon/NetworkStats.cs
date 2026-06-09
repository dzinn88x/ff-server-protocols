using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F3A RID: 3898
	[Token(Token = "0x2000F3A")]
	internal class NetworkStats : SingletonModule<NetworkStats>
	{
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x00011490 File Offset: 0x0000F690
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CD")]
		public ulong TotalPacketSent
		{
			[Token(Token = "0x60037DD")]
			[Address(RVA = "0x2467E44", Offset = "0x2467E44", VA = "0x7BBCC67E44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B980", Offset = "0x113B980")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60037DE")]
			[Address(RVA = "0x2467E4C", Offset = "0x2467E4C", VA = "0x7BBCC67E4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B990", Offset = "0x113B990")]
			private set
			{
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CE")]
		public ulong TotalRUDPPacketSent
		{
			[Token(Token = "0x60037DF")]
			[Address(RVA = "0x2467E54", Offset = "0x2467E54", VA = "0x7BBCC67E54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B9A0", Offset = "0x113B9A0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60037E0")]
			[Address(RVA = "0x2467E5C", Offset = "0x2467E5C", VA = "0x7BBCC67E5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B9B0", Offset = "0x113B9B0")]
			private set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x000114C0 File Offset: 0x0000F6C0
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CF")]
		public ulong TotalRUDPPacketResent
		{
			[Token(Token = "0x60037E1")]
			[Address(RVA = "0x2467E64", Offset = "0x2467E64", VA = "0x7BBCC67E64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B9C0", Offset = "0x113B9C0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60037E2")]
			[Address(RVA = "0x2467E6C", Offset = "0x2467E6C", VA = "0x7BBCC67E6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B9D0", Offset = "0x113B9D0")]
			private set
			{
			}
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x2467E74", Offset = "0x2467E74", VA = "0x7BBCC67E74")]
		public void PacketSent(bool isReliable)
		{
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x2467E94", Offset = "0x2467E94", VA = "0x7BBCC67E94")]
		public void PacketResent()
		{
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x2467EB4", Offset = "0x2467EB4", VA = "0x7BBCC67EB4")]
		public void Clear()
		{
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x2467EC0", Offset = "0x2467EC0", VA = "0x7BBCC67EC0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x2467EC4", Offset = "0x2467EC4", VA = "0x7BBCC67EC4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x2467ED0", Offset = "0x2467ED0", VA = "0x7BBCC67ED0")]
		public NetworkStats()
		{
		}

		// Token: 0x04004A42 RID: 19010
		[Token(Token = "0x4004A42")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E8F4", Offset = "0x112E8F4")]
		private ulong <TotalPacketSent>k__BackingField;

		// Token: 0x04004A43 RID: 19011
		[Token(Token = "0x4004A43")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E904", Offset = "0x112E904")]
		private ulong <TotalRUDPPacketSent>k__BackingField;

		// Token: 0x04004A44 RID: 19012
		[Token(Token = "0x4004A44")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E914", Offset = "0x112E914")]
		private ulong <TotalRUDPPacketResent>k__BackingField;
	}
}
