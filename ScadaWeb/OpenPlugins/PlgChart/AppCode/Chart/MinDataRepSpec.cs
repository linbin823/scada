﻿/*
 * Copyright 2016 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : PlgChart
 * Summary  : Minute data report specification
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2016
 * Modified : 2016
 */

using Scada.Web.Plugins;

namespace Scada.Web.Chart
{
    /// <summary>
    /// Minute data report specification
    /// <para>Спецификация отчёта минутных данных</para>
    /// </summary>
    public class MinDataRepSpec : ReportSpec
    {
        /// <summary>
        /// Получить код типа отчёта
        /// </summary>
        public override string TypeCode
        {
            get
            {
                return "MinDataRep";
            }
        }

        /// <summary>
        /// Получить наименование отчёта
        /// </summary>
        public override string Name
        {
            get
            {
                return Localization.UseRussian ? 
                    "Минутные данные" : 
                    "Minute data";
            }
        }
        
        /// <summary>
        /// Получить признак, что отчёт доступен всем ролям и не требует назначения прав
        /// </summary>
        public override bool ForEveryone
        {
            get
            {
                return true;
            }
        }


        /// <summary>
        /// Получить ссылку на страницу отчёта
        /// </summary>
        public override string GetUrl(int uiObjID)
        {
            return "~/plugins/Chart/MinDataRepParams.aspx";
        }
    }
}