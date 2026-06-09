using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F1C RID: 3868
	[Token(Token = "0x2000F1C")]
	public class ConfigDataManager : SingletonModule<ConfigDataManager>
	{
		// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x25ED174", Offset = "0x25ED174", VA = "0x7BBCDED174", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x25ED178", Offset = "0x25ED178", VA = "0x7BBCDED178", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x25ED230", Offset = "0x25ED230", VA = "0x7BBCDED230")]
		public void InitCsvDecryptionCache()
		{
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x25ED294", Offset = "0x25ED294", VA = "0x7BBCDED294")]
		public void ReleaseCsvDecryptionCache()
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x25ED2A0", Offset = "0x25ED2A0", VA = "0x7BBCDED2A0")]
		private byte[] AcquireSharedBuffer()
		{
			return null;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DE")]
		[Address(RVA = "0x25ED2B0", Offset = "0x25ED2B0", VA = "0x7BBCDED2B0")]
		private void ReleaseSharedBuffer(byte[] buffer)
		{
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x25ED2BC", Offset = "0x25ED2BC", VA = "0x7BBCDED2BC")]
		public TextReader LoadCsvText(ResourceID resID, ref byte[] sharedBuffer)
		{
			return null;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E0")]
		public List<T> LoadCSVNoCache<T>(ResourceID resID) where T : CSVBaseData, new()
		{
			return null;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E1")]
		public List<T> LoadCSVNoCacheCapSize<T>(ResourceID resID) where T : CSVBaseData, new()
		{
			return null;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E2")]
		public void LoadCSVNoCache<T, P>(ResourceID resID, ICollection<P> result) where T : !!1, new() where P : CSVBaseData
		{
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E3")]
		public void LoadCSVNoCache<T>(ResourceID resID, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
		{
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E4")]
		public void LoadCSVNoCacheCapSize<T, P>(ResourceID resID, out List<P> result) where T : !!1, new() where P : CSVBaseData
		{
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E5")]
		public void LoadCSVNoCacheCapSize<T>(ResourceID resID, out Dictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
		{
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E6")]
		public void LoadCSV<T>(ResourceID resID) where T : CSVBaseData, new()
		{
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E7")]
		public void LoadCSVCapSize<T>(ResourceID resID) where T : CSVBaseData, new()
		{
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E8")]
		public List<CSVBaseData> GetDataList<T>() where T : CSVBaseData
		{
			return null;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E9")]
		public Dictionary<string, CSVBaseData> GetDataDictionary<T>() where T : CSVBaseData
		{
			return null;
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EA")]
		public T GetData<T>(string key) where T : CSVBaseData
		{
			return null;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EB")]
		private static string GetDataListsKey<T>() where T : CSVBaseData
		{
			return null;
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EC")]
		private string GetDataItemKey<T>(string pKey) where T : CSVBaseData
		{
			return null;
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036ED")]
		public static List<T> ParseCSV<T>(string csvText) where T : CSVBaseData, new()
		{
			return null;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EE")]
		public static List<T> ParseCSV<T>(TextReader csvText) where T : CSVBaseData, new()
		{
			return null;
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EF")]
		public static List<T> ParseCSVCapSize<T>(TextReader csvText) where T : CSVBaseData, new()
		{
			return null;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x25ED624", Offset = "0x25ED624", VA = "0x7BBCDED624")]
		private static int LineCount(string str)
		{
			return 0;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F1")]
		public static void ParseCSV<T, P>(TextReader csvText, out List<P> result) where T : !!1, new() where P : CSVBaseData
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F2")]
		public static void ParseCSV<T, P>(TextReader reader, ICollection<P> result) where T : !!1, new() where P : CSVBaseData
		{
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F3")]
		public static void ParseCSV<T>(TextReader csvText, out Dictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F4")]
		public static void ParseCSV<T>(TextReader reader, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F5")]
		public T LoadScriptObject<T>(ResourceID resID) where T : ScriptableObject
		{
			return null;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x25ED6D4", Offset = "0x25ED6D4", VA = "0x7BBCDED6D4")]
		private void UnLoadCachedConfigByDataType(string typeStr)
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x25ED7D4", Offset = "0x25ED7D4", VA = "0x7BBCDED7D4")]
		public void UnloadCachedConfigs(List<Type> typeList)
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x25ED8A8", Offset = "0x25ED8A8", VA = "0x7BBCDED8A8")]
		public void ReloadCachedConfigs(List<Type> typeList)
		{
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x25EDBCC", Offset = "0x25EDBCC", VA = "0x7BBCDEDBCC")]
		public ConfigDataManager()
		{
		}

		// Token: 0x040049D2 RID: 18898
		[Token(Token = "0x40049D2")]
		[FieldOffset(Offset = "0x12")]
		public bool UnLoadNoCacheConfigText;

		// Token: 0x040049D3 RID: 18899
		[Token(Token = "0x40049D3")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<CSVBaseData>> m_ConfigDataLists;

		// Token: 0x040049D4 RID: 18900
		[Token(Token = "0x40049D4")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Dictionary<string, CSVBaseData>> m_ConfigDataItemss;

		// Token: 0x040049D5 RID: 18901
		[Token(Token = "0x40049D5")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, ResourceID> m_ConfigLoadResID;

		// Token: 0x040049D6 RID: 18902
		[Token(Token = "0x40049D6")]
		private const int DecryptionBufferSize = 2662400;

		// Token: 0x040049D7 RID: 18903
		[Token(Token = "0x40049D7")]
		[FieldOffset(Offset = "0x30")]
		private byte[] m_DecryptionBuffer;

		// Token: 0x040049D8 RID: 18904
		[Token(Token = "0x40049D8")]
		[FieldOffset(Offset = "0x38")]
		private int m_DecryptorBlockSize;

		// Token: 0x040049D9 RID: 18905
		[Token(Token = "0x40049D9")]
		[FieldOffset(Offset = "0x40")]
		private ICryptoTransform m_Decryptor;
	}
}
