using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001081 RID: 4225
	[Token(Token = "0x2001081")]
	public class AppsFlyerObject : MonoBehaviour
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060040BA RID: 16570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000766")]
		public static AppsFlyerObject Instance
		{
			[Token(Token = "0x60040B9")]
			[Address(RVA = "0x154FA30", Offset = "0x154FA30", VA = "0x7BBBD4FA30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C45C", Offset = "0x113C45C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60040BA")]
			[Address(RVA = "0x15503DC", Offset = "0x15503DC", VA = "0x7BBBD503DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C46C", Offset = "0x113C46C")]
			private set
			{
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x1550430", Offset = "0x1550430", VA = "0x7BBBD50430")]
		private void Awake()
		{
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x155056C", Offset = "0x155056C", VA = "0x7BBBD5056C")]
		private void Start()
		{
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x1550604", Offset = "0x1550604", VA = "0x7BBBD50604")]
		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x1550608", Offset = "0x1550608", VA = "0x7BBBD50608")]
		public void didReceiveConversionData(string conversionData)
		{
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x1550690", Offset = "0x1550690", VA = "0x7BBBD50690")]
		public void didReceiveConversionDataWithError(string error)
		{
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x1550718", Offset = "0x1550718", VA = "0x7BBBD50718")]
		public void onAppOpenAttribution(string validateResult)
		{
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x15507A0", Offset = "0x15507A0", VA = "0x7BBBD507A0")]
		public void onAppOpenAttributionFailure(string error)
		{
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x1550828", Offset = "0x1550828", VA = "0x7BBBD50828")]
		public AppsFlyerObject()
		{
		}

		// Token: 0x0400504A RID: 20554
		[Token(Token = "0x400504A")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EBDC", Offset = "0x112EBDC")]
		private static AppsFlyerObject <Instance>k__BackingField;

		// Token: 0x0400504B RID: 20555
		[Token(Token = "0x400504B")]
		[FieldOffset(Offset = "0x18")]
		public TimeSpan LocalRegistrationTime;
	}
}
