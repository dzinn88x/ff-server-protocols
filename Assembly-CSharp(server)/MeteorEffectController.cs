using System;
using System.Collections.Generic;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
public class MeteorEffectController : MonoBehaviour
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001AF RID: 431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000018")]
	public Queue<MeteorEffectController.MeteorShowerTime> pendingShowTime
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x228DC44", Offset = "0x228DC44", VA = "0x7BBCA8DC44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132280", Offset = "0x1132280")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x228DC4C", Offset = "0x228DC4C", VA = "0x7BBCA8DC4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132290", Offset = "0x1132290")]
		private set
		{
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x228DC54", Offset = "0x228DC54", VA = "0x7BBCA8DC54")]
	private void Awake()
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x228DCE0", Offset = "0x228DCE0", VA = "0x7BBCA8DCE0")]
	private void OnEnable()
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x228E36C", Offset = "0x228E36C", VA = "0x7BBCA8E36C")]
	[SkipRename]
	private void TickMeteorShower()
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x228E838", Offset = "0x228E838", VA = "0x7BBCA8E838")]
	private void OnDestroy()
	{
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x228E2F0", Offset = "0x228E2F0", VA = "0x7BBCA8E2F0")]
	private DateTime GetDayOfTheNight(DateTime time)
	{
		return default(DateTime);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x228E3C4", Offset = "0x228E3C4", VA = "0x7BBCA8E3C4")]
	private bool IsInMeteorShowerTime()
	{
		return default(bool);
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x228E5A4", Offset = "0x228E5A4", VA = "0x7BBCA8E5A4")]
	private void StartMeteorShower()
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x228E7A8", Offset = "0x228E7A8", VA = "0x7BBCA8E7A8")]
	private void StopMeteorShower()
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x228E8E4", Offset = "0x228E8E4", VA = "0x7BBCA8E8E4")]
	public MeteorEffectController()
	{
	}

	// Token: 0x040001CD RID: 461
	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject meteorPrefab;

	// Token: 0x040001CE RID: 462
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFCAC", Offset = "0x10FFCAC")]
	public int meteorStartHour;

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x24")]
	public int meteorEndHour;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x28")]
	public int[] timeSegments;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x30")]
	private bool isDuringMeteorShower;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x34")]
	private int generalMeteorDuration;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x38")]
	private GameObject instance;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem[] particles;

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x48")]
	public string meteorSpecificTime;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x50")]
	private int weatherNightEnd;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x54")]
	private int weatherNightStart;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFCE4", Offset = "0x10FFCE4")]
	private Queue<MeteorEffectController.MeteorShowerTime> <pendingShowTime>k__BackingField;

	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public struct MeteorShowerTime
	{
		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		public DateTime startTime;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x8")]
		public DateTime endTime;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x10")]
		public bool isRandom;
	}
}
