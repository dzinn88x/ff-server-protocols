using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CD7 RID: 7383
	[Token(Token = "0x2001CD7")]
	public class EventClothEffectDataManager : SingletonModule<EventClothEffectDataManager>
	{
		// Token: 0x0600A11B RID: 41243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11B")]
		[Address(RVA = "0x1B87B38", Offset = "0x1B87B38", VA = "0x7BBC387B38", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11C")]
		[Address(RVA = "0x1B87B3C", Offset = "0x1B87B3C", VA = "0x7BBC387B3C")]
		public void LoadCSVData()
		{
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11D")]
		[Address(RVA = "0x1B882B8", Offset = "0x1B882B8", VA = "0x7BBC3882B8", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x0002A468 File Offset: 0x00028668
		[Token(Token = "0x600A11E")]
		[Address(RVA = "0x1B8833C", Offset = "0x1B8833C", VA = "0x7BBC38833C")]
		public bool IsClientClothEffects(EventClothEffectDataManager.EBehaviorClientType behaviorType, uint stateId)
		{
			return default(bool);
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A11F")]
		[Address(RVA = "0x1B883E4", Offset = "0x1B883E4", VA = "0x7BBC3883E4")]
		public EventClothEffectsData GetEventClothEffectsDataByID(uint stateID)
		{
			return null;
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A120")]
		[Address(RVA = "0x1B88464", Offset = "0x1B88464", VA = "0x7BBC388464")]
		public void GetEventClothEffectsDataByClothes(uint clothesId, List<EventClothEffectsData> list, bool partialClone = false)
		{
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A121")]
		[Address(RVA = "0x1B886CC", Offset = "0x1B886CC", VA = "0x7BBC3886CC")]
		public EventClothEffectDataManager()
		{
		}

		// Token: 0x0400A7C5 RID: 42949
		[Token(Token = "0x400A7C5")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, EventClothEffectsData> m_DictStateIdToData;

		// Token: 0x0400A7C6 RID: 42950
		[Token(Token = "0x400A7C6")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, List<uint>> m_StateIdListDict;

		// Token: 0x02001CD8 RID: 7384
		[Token(Token = "0x2001CD8")]
		public enum EBehaviorClientType
		{
			// Token: 0x0400A7C8 RID: 42952
			[Token(Token = "0x400A7C8")]
			SafeZone = 9
		}

		// Token: 0x02001CD9 RID: 7385
		[Token(Token = "0x2001CD9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA24", Offset = "0x10FBA24")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600A122 RID: 41250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A122")]
			[Address(RVA = "0x1B882B0", Offset = "0x1B882B0", VA = "0x7BBC3882B0")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0600A123 RID: 41251 RVA: 0x0002A480 File Offset: 0x00028680
			[Token(Token = "0x600A123")]
			[Address(RVA = "0x1B8878C", Offset = "0x1B8878C", VA = "0x7BBC38878C")]
			internal bool <LoadCSVData>b__0(EventTriggerData x)
			{
				return default(bool);
			}

			// Token: 0x0400A7C9 RID: 42953
			[Token(Token = "0x400A7C9")]
			[FieldOffset(Offset = "0x10")]
			public EventClothEffectsData data;
		}
	}
}
