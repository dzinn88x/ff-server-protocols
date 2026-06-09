using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C1E RID: 7198
	[Token(Token = "0x2001C1E")]
	internal class FrontEndGame : COWGameBase
	{
		// Token: 0x06009CA8 RID: 40104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CA8")]
		[Address(RVA = "0x1865C70", Offset = "0x1865C70", VA = "0x7BBC065C70", Slot = "17")]
		public override ResourceID[] GetResourceID()
		{
			return null;
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CA9")]
		[Address(RVA = "0x1865CD8", Offset = "0x1865CD8", VA = "0x7BBC065CD8", Slot = "18")]
		public override Type GetUISceneType()
		{
			return null;
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CAA")]
		[Address(RVA = "0x1865D48", Offset = "0x1865D48", VA = "0x7BBC065D48", Slot = "9")]
		protected override void OnSceneLoaded()
		{
		}

		// Token: 0x06009CAB RID: 40107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CAB")]
		[Address(RVA = "0x18660B0", Offset = "0x18660B0", VA = "0x7BBC0660B0", Slot = "19")]
		public override ResourceID[] GetPreloadResourceID()
		{
			return null;
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x000291D8 File Offset: 0x000273D8
		[Token(Token = "0x6009CAC")]
		[Address(RVA = "0x186617C", Offset = "0x186617C", VA = "0x7BBC06617C", Slot = "24")]
		public override int GetGameType()
		{
			return 0;
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CAD")]
		[Address(RVA = "0x1866184", Offset = "0x1866184", VA = "0x7BBC066184", Slot = "7")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1145284", Offset = "0x1145284")]
		public override IEnumerator OnPreprocessFinished()
		{
			return null;
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CAE")]
		[Address(RVA = "0x1866210", Offset = "0x1866210", VA = "0x7BBC066210", Slot = "12")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CAF")]
		[Address(RVA = "0x1866930", Offset = "0x1866930", VA = "0x7BBC066930", Slot = "5")]
		public override void OnStartLoadScene()
		{
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CB0")]
		[Address(RVA = "0x1866BE0", Offset = "0x1866BE0", VA = "0x7BBC066BE0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x000291F0 File Offset: 0x000273F0
		[Token(Token = "0x6009CB1")]
		[Address(RVA = "0x1866964", Offset = "0x1866964", VA = "0x7BBC066964")]
		private bool NeedUnloadCSVFromMemory()
		{
			return default(bool);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CB2")]
		[Address(RVA = "0x1866C9C", Offset = "0x1866C9C", VA = "0x7BBC066C9C")]
		private void UnloadCSVDataFromMemory()
		{
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CB3")]
		[Address(RVA = "0x1866A30", Offset = "0x1866A30", VA = "0x7BBC066A30")]
		private void ReloadCSVDataFromMemory()
		{
		}

		// Token: 0x06009CB4 RID: 40116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CB4")]
		[Address(RVA = "0x1866E88", Offset = "0x1866E88", VA = "0x7BBC066E88")]
		public void ReloadTranslation(bool needOverride = false)
		{
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CB5")]
		[Address(RVA = "0x18670D8", Offset = "0x18670D8", VA = "0x7BBC0670D8")]
		public FrontEndGame()
		{
		}

		// Token: 0x0400A29D RID: 41629
		[Token(Token = "0x400A29D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ResourceID[] SCENE_RESOURCE_LIST;

		// Token: 0x0400A29E RID: 41630
		[Token(Token = "0x400A29E")]
		[FieldOffset(Offset = "0x68")]
		public PostEffectManager postEffect;

		// Token: 0x0400A29F RID: 41631
		[Token(Token = "0x400A29F")]
		[FieldOffset(Offset = "0x70")]
		private bool m_SceneLoaded;

		// Token: 0x0400A2A0 RID: 41632
		[Token(Token = "0x400A2A0")]
		[FieldOffset(Offset = "0x8")]
		private static List<Type> CacheTypesNeedsUnload;

		// Token: 0x02001C1F RID: 7199
		[Token(Token = "0x2001C1F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB6BC", Offset = "0x10FB6BC")]
		private sealed class <OnPreprocessFinished>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06009CB7 RID: 40119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CB7")]
			[Address(RVA = "0x18661E4", Offset = "0x18661E4", VA = "0x7BBC0661E4")]
			[DebuggerHidden]
			public <OnPreprocessFinished>d__8(int <>1__state)
			{
			}

			// Token: 0x06009CB8 RID: 40120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CB8")]
			[Address(RVA = "0x1867524", Offset = "0x1867524", VA = "0x7BBC067524", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06009CB9 RID: 40121 RVA: 0x00029208 File Offset: 0x00027408
			[Token(Token = "0x6009CB9")]
			[Address(RVA = "0x1867528", Offset = "0x1867528", VA = "0x7BBC067528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x06009CBA RID: 40122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A5F")]
			private object Current
			{
				[Token(Token = "0x6009CBA")]
				[Address(RVA = "0x1867564", Offset = "0x1867564", VA = "0x7BBC067564", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06009CBB RID: 40123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CBB")]
			[Address(RVA = "0x186756C", Offset = "0x186756C", VA = "0x7BBC06756C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x06009CBC RID: 40124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A60")]
			private object Current
			{
				[Token(Token = "0x6009CBC")]
				[Address(RVA = "0x18675D4", Offset = "0x18675D4", VA = "0x7BBC0675D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A2A1 RID: 41633
			[Token(Token = "0x400A2A1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A2A2 RID: 41634
			[Token(Token = "0x400A2A2")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}

		// Token: 0x02001C20 RID: 7200
		[Token(Token = "0x2001C20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB6CC", Offset = "0x10FB6CC")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06009CBD RID: 40125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CBD")]
			[Address(RVA = "0x1866840", Offset = "0x1866840", VA = "0x7BBC066840")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06009CBE RID: 40126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CBE")]
			[Address(RVA = "0x1867384", Offset = "0x1867384", VA = "0x7BBC067384")]
			internal void <OnUpdate>b__0()
			{
			}

			// Token: 0x0400A2A3 RID: 41635
			[Token(Token = "0x400A2A3")]
			[FieldOffset(Offset = "0x10")]
			public DisconnectedReason reason;
		}
	}
}
