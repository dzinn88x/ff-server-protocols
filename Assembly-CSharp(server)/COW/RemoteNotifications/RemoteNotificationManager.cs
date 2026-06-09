using System;
using Il2CppDummyDll;

namespace COW.RemoteNotifications
{
	// Token: 0x02002692 RID: 9874
	[Token(Token = "0x2002692")]
	public class RemoteNotificationManager
	{
		// Token: 0x0600CC5F RID: 52319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC5F")]
		[Address(RVA = "0x17546F8", Offset = "0x17546F8", VA = "0x7BBBF546F8")]
		protected RemoteNotificationManager()
		{
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAF")]
		public static RemoteNotificationManager I
		{
			[Token(Token = "0x600CC60")]
			[Address(RVA = "0x1754700", Offset = "0x1754700", VA = "0x7BBBF54700")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC61")]
		[Address(RVA = "0x175540C", Offset = "0x175540C", VA = "0x7BBBF5540C")]
		protected static void _Log(string log)
		{
		}

		// Token: 0x0600CC62 RID: 52322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC62")]
		[Address(RVA = "0x1755474", Offset = "0x1755474", VA = "0x7BBBF55474")]
		protected static void _LogError(string log)
		{
		}

		// Token: 0x0600CC63 RID: 52323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC63")]
		[Address(RVA = "0x17554DC", Offset = "0x17554DC", VA = "0x7BBBF554DC")]
		internal static void Log(string log)
		{
		}

		// Token: 0x0600CC64 RID: 52324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC64")]
		[Address(RVA = "0x17554E0", Offset = "0x17554E0", VA = "0x7BBBF554E0", Slot = "4")]
		public virtual void BeforeLoginSDK()
		{
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC65")]
		[Address(RVA = "0x17554E4", Offset = "0x17554E4", VA = "0x7BBBF554E4", Slot = "5")]
		public virtual void AfterLoginSDK()
		{
		}

		// Token: 0x0600CC66 RID: 52326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC66")]
		[Address(RVA = "0x17554E8", Offset = "0x17554E8", VA = "0x7BBBF554E8", Slot = "6")]
		public virtual void BeforeLoginServer()
		{
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC67")]
		[Address(RVA = "0x17554EC", Offset = "0x17554EC", VA = "0x7BBBF554EC", Slot = "7")]
		public virtual void AfterLoginServer()
		{
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC68")]
		[Address(RVA = "0x17554F0", Offset = "0x17554F0", VA = "0x7BBBF554F0", Slot = "8")]
		public virtual void BeforeLogoutServer()
		{
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC69")]
		[Address(RVA = "0x17554F4", Offset = "0x17554F4", VA = "0x7BBBF554F4", Slot = "9")]
		public virtual void AfterLogoutServer()
		{
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6A")]
		[Address(RVA = "0x17554F8", Offset = "0x17554F8", VA = "0x7BBBF554F8", Slot = "10")]
		public virtual void BeforeLogoutSDK()
		{
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6B")]
		[Address(RVA = "0x17554FC", Offset = "0x17554FC", VA = "0x7BBBF554FC", Slot = "11")]
		public virtual void AfterLogoutSDK()
		{
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6C")]
		[Address(RVA = "0x1755500", Offset = "0x1755500", VA = "0x7BBBF55500", Slot = "12")]
		public virtual void BeforeChangeLanguage()
		{
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6D")]
		[Address(RVA = "0x1755504", Offset = "0x1755504", VA = "0x7BBBF55504", Slot = "13")]
		public virtual void AfterChangeLanguage()
		{
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6E")]
		[Address(RVA = "0x1755508", Offset = "0x1755508", VA = "0x7BBBF55508", Slot = "14")]
		public virtual void BeforeChangeFirstTimePaid()
		{
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6F")]
		[Address(RVA = "0x175550C", Offset = "0x175550C", VA = "0x7BBBF5550C", Slot = "15")]
		public virtual void AfterChangeFirstTimePaid()
		{
		}

		// Token: 0x0600CC70 RID: 52336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC70")]
		[Address(RVA = "0x1755510", Offset = "0x1755510", VA = "0x7BBBF55510", Slot = "16")]
		public virtual void BeforeChangeClanID()
		{
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC71")]
		[Address(RVA = "0x1755514", Offset = "0x1755514", VA = "0x7BBBF55514", Slot = "17")]
		public virtual void AfterChangeClanID()
		{
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC72")]
		[Address(RVA = "0x1755518", Offset = "0x1755518", VA = "0x7BBBF55518", Slot = "18")]
		public virtual void BeforeChangeElitePassBadgeNumber()
		{
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC73")]
		[Address(RVA = "0x175551C", Offset = "0x175551C", VA = "0x7BBBF5551C", Slot = "19")]
		public virtual void AfterChangeElitePassBadgeNumber()
		{
		}

		// Token: 0x0600CC74 RID: 52340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC74")]
		[Address(RVA = "0x1755520", Offset = "0x1755520", VA = "0x7BBBF55520", Slot = "20")]
		public virtual void BeforeChangePlayerLevel()
		{
		}

		// Token: 0x0600CC75 RID: 52341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC75")]
		[Address(RVA = "0x1755524", Offset = "0x1755524", VA = "0x7BBBF55524", Slot = "21")]
		public virtual void AfterChangePlayerLevel()
		{
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC76")]
		[Address(RVA = "0x1755528", Offset = "0x1755528", VA = "0x7BBBF55528", Slot = "22")]
		public virtual void BeforeChangeGamesPlayedInRankedMatch()
		{
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC77")]
		[Address(RVA = "0x175552C", Offset = "0x175552C", VA = "0x7BBBF5552C", Slot = "23")]
		public virtual void AfterChangeGamesPlayedInRankedMatch()
		{
		}

		// Token: 0x0401004C RID: 65612
		[Token(Token = "0x401004C")]
		[FieldOffset(Offset = "0x0")]
		private static RemoteNotificationManager _I;
	}
}
