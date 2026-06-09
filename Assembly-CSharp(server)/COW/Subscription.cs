using System;
using GarenaMSDK;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C91 RID: 7313
	[Token(Token = "0x2001C91")]
	public class Subscription
	{
		// Token: 0x06009F99 RID: 40857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F99")]
		[Address(RVA = "0x1B40C98", Offset = "0x1B40C98", VA = "0x7BBC340C98")]
		private void _UpdateNextPaymentTime()
		{
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06009F9A RID: 40858 RVA: 0x00029A90 File Offset: 0x00027C90
		// (set) Token: 0x06009F9B RID: 40859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A81")]
		public int LastPaymentTime
		{
			[Token(Token = "0x6009F9A")]
			[Address(RVA = "0x1B40E98", Offset = "0x1B40E98", VA = "0x7BBC340E98")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009F9B")]
			[Address(RVA = "0x1B40EA0", Offset = "0x1B40EA0", VA = "0x7BBC340EA0")]
			set
			{
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06009F9C RID: 40860 RVA: 0x00029AA8 File Offset: 0x00027CA8
		// (set) Token: 0x06009F9D RID: 40861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A82")]
		public SubscriptionPeriod Period
		{
			[Token(Token = "0x6009F9C")]
			[Address(RVA = "0x1B40E90", Offset = "0x1B40E90", VA = "0x7BBC340E90")]
			get
			{
				return SubscriptionPeriod.None;
			}
			[Token(Token = "0x6009F9D")]
			[Address(RVA = "0x1B40EA8", Offset = "0x1B40EA8", VA = "0x7BBC340EA8")]
			set
			{
			}
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F9E")]
		[Address(RVA = "0x1B40EB0", Offset = "0x1B40EB0", VA = "0x7BBC340EB0")]
		public static Subscription _(SDKIAP.Subscription subscription)
		{
			return null;
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x00029AC0 File Offset: 0x00027CC0
		[Token(Token = "0x6009F9F")]
		[Address(RVA = "0x1B40E80", Offset = "0x1B40E80", VA = "0x7BBC340E80")]
		public bool HasLastPaymentTime()
		{
			return default(bool);
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x00029AD8 File Offset: 0x00027CD8
		[Token(Token = "0x6009FA0")]
		[Address(RVA = "0x1B40FD4", Offset = "0x1B40FD4", VA = "0x7BBC340FD4")]
		public bool HasNextPaymentTime()
		{
			return default(bool);
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x00029AF0 File Offset: 0x00027CF0
		[Token(Token = "0x17000A83")]
		public int NextPaymentTime
		{
			[Token(Token = "0x6009FA1")]
			[Address(RVA = "0x1B40FE4", Offset = "0x1B40FE4", VA = "0x7BBC340FE4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x00029B08 File Offset: 0x00027D08
		[Token(Token = "0x6009FA2")]
		[Address(RVA = "0x1B40FEC", Offset = "0x1B40FEC", VA = "0x7BBC340FEC")]
		private bool? PaymentOverdue()
		{
			return null;
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x00029B20 File Offset: 0x00027D20
		[Token(Token = "0x6009FA3")]
		[Address(RVA = "0x1B41098", Offset = "0x1B41098", VA = "0x7BBC341098")]
		public bool WillBegin()
		{
			return default(bool);
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x00029B38 File Offset: 0x00027D38
		[Token(Token = "0x6009FA4")]
		[Address(RVA = "0x1B410A8", Offset = "0x1B410A8", VA = "0x7BBC3410A8")]
		public bool WithinPeriod()
		{
			return default(bool);
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x00029B50 File Offset: 0x00027D50
		[Token(Token = "0x6009FA5")]
		[Address(RVA = "0x1B41154", Offset = "0x1B41154", VA = "0x7BBC341154")]
		public bool HasEnded()
		{
			return default(bool);
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x00029B68 File Offset: 0x00027D68
		[Token(Token = "0x6009FA6")]
		[Address(RVA = "0x1B4124C", Offset = "0x1B4124C", VA = "0x7BBC34124C")]
		public bool CanSubscribe()
		{
			return default(bool);
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06009FA7 RID: 40871 RVA: 0x00029B80 File Offset: 0x00027D80
		[Token(Token = "0x17000A84")]
		public long GracePeriodExpiryTime
		{
			[Token(Token = "0x6009FA7")]
			[Address(RVA = "0x1B41278", Offset = "0x1B41278", VA = "0x7BBC341278")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06009FA8 RID: 40872 RVA: 0x00029B98 File Offset: 0x00027D98
		[Token(Token = "0x17000A85")]
		public bool IsInGracePeriod
		{
			[Token(Token = "0x6009FA8")]
			[Address(RVA = "0x1B41280", Offset = "0x1B41280", VA = "0x7BBC341280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06009FA9 RID: 40873 RVA: 0x00029BB0 File Offset: 0x00027DB0
		[Token(Token = "0x17000A86")]
		public long OnHoldSince
		{
			[Token(Token = "0x6009FA9")]
			[Address(RVA = "0x1B412F4", Offset = "0x1B412F4", VA = "0x7BBC3412F4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06009FAA RID: 40874 RVA: 0x00029BC8 File Offset: 0x00027DC8
		[Token(Token = "0x17000A87")]
		public bool IsOnHold
		{
			[Token(Token = "0x6009FAA")]
			[Address(RVA = "0x1B412FC", Offset = "0x1B412FC", VA = "0x7BBC3412FC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FAB")]
		[Address(RVA = "0x1B4130C", Offset = "0x1B4130C", VA = "0x7BBC34130C")]
		public static string Brief(Subscription subscription)
		{
			return null;
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FAC")]
		[Address(RVA = "0x1B415B0", Offset = "0x1B415B0", VA = "0x7BBC3415B0")]
		public static string Detail(Subscription subscription)
		{
			return null;
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAD")]
		[Address(RVA = "0x1B40FCC", Offset = "0x1B40FCC", VA = "0x7BBC340FCC")]
		public Subscription()
		{
		}

		// Token: 0x0400A65B RID: 42587
		[Token(Token = "0x400A65B")]
		[FieldOffset(Offset = "0x10")]
		private int _LastPaymentTime;

		// Token: 0x0400A65C RID: 42588
		[Token(Token = "0x400A65C")]
		[FieldOffset(Offset = "0x14")]
		private int _NextPaymentTime;

		// Token: 0x0400A65D RID: 42589
		[Token(Token = "0x400A65D")]
		[FieldOffset(Offset = "0x18")]
		private SubscriptionPeriod _Period;

		// Token: 0x0400A65E RID: 42590
		[Token(Token = "0x400A65E")]
		[FieldOffset(Offset = "0x20")]
		private long _GracePeriodExpiryTime;

		// Token: 0x0400A65F RID: 42591
		[Token(Token = "0x400A65F")]
		[FieldOffset(Offset = "0x28")]
		private long _OnHoldSince;

		// Token: 0x0400A660 RID: 42592
		[Token(Token = "0x400A660")]
		[FieldOffset(Offset = "0x30")]
		public SubscriptionStatus Status;

		// Token: 0x0400A661 RID: 42593
		[Token(Token = "0x400A661")]
		public const string PAYMENT_TIME_FORMAT_TO_MINS = "yyyy-MM-dd H:mm";

		// Token: 0x0400A662 RID: 42594
		[Token(Token = "0x400A662")]
		public const string PAYMENT_TIME_FORMAT_TO_DATE = "yyyy-MM-dd";

		// Token: 0x0400A663 RID: 42595
		[Token(Token = "0x400A663")]
		public const int TEST_RENEWAL_INTERVAL_SECS = 300;
	}
}
